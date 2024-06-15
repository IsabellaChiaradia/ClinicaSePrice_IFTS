using System;
using ClinicaSePrice.Enum;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePrice.Entidades;

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

        public void RegistrarTurno(int idPaciente, int idPractica, DateTime fechaTurno, DateTime horaInicio, DateTime horaFin)
        {
            try
            {
                using MySqlCommand comando = new MySqlCommand("sp_alta_turno", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("p_fecha_atencion", MySqlDbType.Date).Value = fechaTurno.Date;
                comando.Parameters.Add("p_hora_inicio", MySqlDbType.Time).Value = horaInicio.TimeOfDay;
                comando.Parameters.Add("p_hora_fin", MySqlDbType.Time).Value = horaFin.TimeOfDay;
                comando.Parameters.Add("p_costo_final", MySqlDbType.Decimal).Value = ObtenerCostoPractica(idPractica, idPaciente);
                comando.Parameters.Add("p_id_paciente", MySqlDbType.Int32).Value = idPaciente;
                //comando.Parameters.Add("p_id_medico", MySqlDbType.Int32).Value = idMedico.Value; 
                comando.Parameters.Add("p_id_practica", MySqlDbType.Int32).Value = idPractica;
                comando.Parameters.Add("rta", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                sqlCon.Open();
                comando.ExecuteNonQuery();
                int respuesta = Convert.ToInt32(comando.Parameters["rta"].Value);

                if (respuesta == 1)
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
            turnosPosiblesDt.Columns.Add("Disponible", typeof(Boolean));
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
                newRow["Disponible"] = row["idTurno"] == DBNull.Value;
                // Asigna más columnas según sea necesario
                turnosPosiblesDt.Rows.Add(newRow);
            }

            tablaTurno.DataSource = turnosPosiblesDt;

            // Opcionalmente, configurar la apariencia del DataGridView
            tablaTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
