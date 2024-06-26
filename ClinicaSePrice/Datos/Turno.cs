﻿using System;
using ClinicaSePrice.Enum;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePrice.Entidades;
using System.Windows.Forms;
using Org.BouncyCastle.Utilities;

namespace ClinicaSePrice.Datos
{
    internal class Turno
    {
        private MySqlConnection sqlCon;

        public Turno()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public void obtenerTurnosDisponiblesXEspecialidad(DataGridView tablaTurno, DateTime fechaDesde, DateTime fechaHasta, int idEspecialidad)
        {
            ejecutarProcedimientoTurnos(tablaTurno, "sp_consulta_turnos_posibles_x_especialidad", fechaDesde, fechaHasta, idEspecialidad, null);
        }

        public void obtenerTurnosDisponiblesXMedico(DataGridView tablaTurno, DateTime fechaDesde, DateTime fechaHasta, int idMedico)
        {
            ejecutarProcedimientoTurnos(tablaTurno, "sp_consulta_turnos_posibles_x_medico", fechaDesde, fechaHasta, null, idMedico);
        }

        public int RegistrarTurno(int idPaciente, int idMedico, int idPractica, DateTime? fechaTurno, TimeSpan? horaInicio, TimeSpan? horaFin)
        {
            int respuesta = 0;
            try
            {
                using MySqlCommand comando = new MySqlCommand("sp_alta_turno", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("i_fecha_atencion", MySqlDbType.Date).Value = fechaTurno;
                comando.Parameters.Add("i_hora_inicio", MySqlDbType.Time).Value = horaInicio;
                comando.Parameters.Add("i_hora_fin", MySqlDbType.Time).Value = horaFin;
                comando.Parameters.Add("i_id_paciente", MySqlDbType.Int32).Value = idPaciente;
                comando.Parameters.Add("i_id_medico", MySqlDbType.Int32).Value = idMedico;
                comando.Parameters.Add("i_id_practica", MySqlDbType.Int32).Value = idPractica;
                comando.Parameters.Add("rta", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToInt32(comando.Parameters["rta"].Value);

                if (respuesta > -1)
                {
                    MessageBox.Show("Turno registrado correctamente", "AVISO DEL SISTEMA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el turno", "AVISO DEL SISTEMA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el turno: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return respuesta;
        }

        private decimal ObtenerCostoPractica(int idPractica, int idPaciente)
        {
            Practica practica = new Practica();
            return practica.ObtenerCostoPractica(idPractica, idPaciente);
        }        

        private void ejecutarProcedimientoTurnos(DataGridView tablaTurno, string procedimiento, DateTime fechaDesde, DateTime fechaHasta, int? idEspecialidad, int? idMedico)
        {
            try
            {
                tablaTurno.DataSource = null;
                var dt = new DataTable();

                // using se utiliza con los objetos MySqlConnection, MySqlCommand y MySqlDataReader. Esto garantiza que estos objetos se liberen correctamente y que se cierren las conexiones de base de datos una vez que ya no se necesiten, incluso si ocurren excepciones durante la ejecución del código. Esto ayuda a prevenir pérdidas de recursos y posibles problemas de conexión con la base de datos.

                using MySqlCommand comando = new MySqlCommand(procedimiento, sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("i_fecha_desde", MySqlDbType.Date).Value = fechaDesde;
                comando.Parameters.Add("i_fecha_hasta", MySqlDbType.Date).Value = fechaHasta;

                if (idEspecialidad.HasValue)
                {
                    comando.Parameters.Add("i_id_especialidad", MySqlDbType.Int32).Value = idEspecialidad.Value;
                }

                if (idMedico.HasValue)
                {
                    comando.Parameters.Add("i_id_medico", MySqlDbType.Int32).Value = idMedico.Value;
                    comando.Parameters.Add("i_show_results", MySqlDbType.Bit).Value = true;
                }

                sqlCon.Open();

                using MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.HasRows)
                {
                    procesarConsultaTurnos(tablaTurno, resultado, dt);
                }
                else
                {
                    MessageBox.Show("No existen turnos disponibles para esta selección",
                                    "AVISO DEL SISTEMA",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al cargar la tabla con los turnos disponibles" + error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


        public void ObtenerTurnosAPagar(int idPaciente, DataGridView tablaTurno)
        {
            tablaTurno.DataSource = null;
            var resultado = GetTurnosAPagarDelDia(idPaciente);
            if (resultado.HasRows)
            {
                procesarConsultaTurnosAPagar(tablaTurno, resultado);
            }
            else
            {
                MessageBox.Show("No existen turnos a pagar para el paciente seleccionado",
                                "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }

        }

        public int PagarTurno(int idTurno, double costoFinal)
        {
            int result = -1; 
            try
            {
                sqlCon.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_pagar_turno", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir los parámetros de entrada
                    cmd.Parameters.AddWithValue("@i_idTurno", idTurno);
                    cmd.Parameters.AddWithValue("@i_costoFinal", costoFinal);

                    cmd.Parameters.Add(new MySqlParameter("@o_result", MySqlDbType.Int32));
                    cmd.Parameters["@o_result"].Direction = ParameterDirection.Output;

                    
                    cmd.ExecuteNonQuery();
                    result = (int)cmd.Parameters["@o_result"].Value;
                }
            }
            catch (MySqlException ex)
            {
                // Manejar errores aquí
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar errores generales aquí
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return result;

        }


        public MySqlDataReader GetTurnosAPagarDelDia(int idPaciente)
        {
            MySqlDataReader reader = null;
            try
            {
                sqlCon.Open();
                string query = @"
                SELECT 
                    t.idTurno, 
                    t.fechaAtencion, 
                    t.horaInicio, 
                    t.horaFin, 
                    t.acreditado, 
                    t.costoFinal, 
                    CONCAT(m.nombre, ' ', m.apellido) as medico, 
                    p.descripcion as practica, 
                    p.costo
                FROM 
                    turno t
                INNER JOIN 
                    medico m ON t.id_medico = m.idMedico
                INNER JOIN 
                    practica p ON t.id_practica = p.idPractica
                WHERE 
                    t.id_paciente = @idPaciente 
                    AND t.fechaAtencion = CURDATE() 
                    AND t.fechaBaja IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los turnos a pagar: " + ex.Message);
            }
            return reader;
        }



        private void procesarConsultaTurnos(DataGridView tablaTurno, MySqlDataReader resultado, DataTable dt)
        {
            dt.Load(resultado);
            DataTable turnosPosiblesDt = new DataTable();

            // Añadir las columnas que te interesan
            turnosPosiblesDt.Columns.Add("Día", typeof(string)); // Tipo según el tipo de dato
            turnosPosiblesDt.Columns.Add("Fecha Atencion", typeof(DateTime));
            turnosPosiblesDt.Columns.Add("Inicio", typeof(TimeSpan));
            turnosPosiblesDt.Columns.Add("Fin", typeof(TimeSpan));
            turnosPosiblesDt.Columns.Add("Medico", typeof(string));
            turnosPosiblesDt.Columns.Add("Disponible", typeof(string));

            // Agrega más columnas según sea necesario

            // Copiar datos filtrados
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = turnosPosiblesDt.NewRow();
                newRow["Día"] = obtenerNombreDia(Convert.ToInt32(row["dia"]));
                newRow["Fecha Atencion"] = row["fecha"];
                newRow["Inicio"] = row["hora_inicio"];
                newRow["Fin"] = row["hora_fin"];
                newRow["Medico"] = row["nombre_completo"];
                newRow["Disponible"] = row["idTurno"] == DBNull.Value ? "✔️" : "❌";
                // Asigna más columnas según sea necesario
                turnosPosiblesDt.Rows.Add(newRow);
            }

            tablaTurno.DataSource = turnosPosiblesDt;

            // Opcionalmente, configurar la apariencia del DataGridView
            tablaTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaTurno.Columns["Disponible"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Deseleccionar todas las filas
            tablaTurno.ClearSelection();

            for (int i = 0; i < tablaTurno.Rows.Count; i++)
            {
                tablaTurno.Rows[i].Tag = dt.Rows[i]; // Guardar la fila original completa en el Tag
            }

            this.agregarColorXDisponibilidad(tablaTurno);
        }

        private void procesarConsultaTurnosAPagar(DataGridView tablaTurno, MySqlDataReader resultado)
        {
            var dtOriginal = new DataTable();
            dtOriginal.Load(resultado);
            DataTable dtTurnosAPagar = new DataTable();

            // Añadimos las columnas que queremos mostrar el usuario
            dtTurnosAPagar.Columns.Add("Fecha Atencion", typeof(DateTime));
            dtTurnosAPagar.Columns.Add("Inicio", typeof(TimeSpan));
            dtTurnosAPagar.Columns.Add("Fin", typeof(TimeSpan));
            dtTurnosAPagar.Columns.Add("Medico", typeof(string));
            dtTurnosAPagar.Columns.Add("Practica", typeof(string));
            dtTurnosAPagar.Columns.Add("Acreditado", typeof(Boolean));
            dtTurnosAPagar.Columns.Add("Costo final", typeof(string));



            // Copiar datos filtrados
            foreach (DataRow row in dtOriginal.Rows)
            {
                DataRow newRow = dtTurnosAPagar.NewRow();
                newRow["Fecha Atencion"] = row["fechaAtencion"];
                newRow["Inicio"] = row["horaInicio"];
                newRow["Fin"] = row["horaFin"];
                newRow["Medico"] = row["medico"];
                newRow["Practica"] = row["practica"];
                newRow["Acreditado"] = row["acreditado"];

                decimal costoFinal = row["costoFinal"] != DBNull.Value ? (decimal)row["costoFinal"] : 0;
                newRow["Costo final"] = costoFinal == 0 ? "" : Math.Round(costoFinal, 2).ToString();

                dtTurnosAPagar.Rows.Add(newRow);
            }

            tablaTurno.DataSource = dtTurnosAPagar;

            // Opcionalmente, configurar la apariencia del DataGridView
            tablaTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Deseleccionar todas las filas
            tablaTurno.ClearSelection();

            for (int i = 0; i < tablaTurno.Rows.Count; i++)
            {
                tablaTurno.Rows[i].Tag = dtOriginal.Rows[i]; // Guardar la fila original completa en el Tag
            }

        }


        private void agregarColorXDisponibilidad(DataGridView tablaTurno)
        {
            foreach (DataGridViewRow row in tablaTurno.Rows)
            {
                DataRow? filaOriginal = row.Tag as DataRow;
                if (filaOriginal["idTurno"] == DBNull.Value)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }



        // El diccionario DiaSemanaNombres es una colección de pares clave-valor, donde la clave es un valor del enum DiaSemana y el valor es una cadena que representa el nombre del día con tildes.
        private static readonly Dictionary<DiaSemanaEnum, string> DiaSemanaNombres = new Dictionary<DiaSemanaEnum, string>
        {
            { DiaSemanaEnum.Domingo, "Domingo" },
            { DiaSemanaEnum.Lunes, "Lunes" },
            { DiaSemanaEnum.Martes, "Martes" },
            { DiaSemanaEnum.Miercoles, "Miércoles" },  
            { DiaSemanaEnum.Jueves, "Jueves" },
            { DiaSemanaEnum.Viernes, "Viernes" },
            { DiaSemanaEnum.Sabado, "Sábado" }  
        };

        public string obtenerNombreDia(int dia)
        {
            if (dia >= (int)DiaSemanaEnum.Domingo && dia <= (int)DiaSemanaEnum.Sabado)
            {
                DiaSemanaEnum diaEnum = (DiaSemanaEnum)dia;
                return DiaSemanaNombres[diaEnum];
            }
            return "Desconocido";
        }      

    }
}
