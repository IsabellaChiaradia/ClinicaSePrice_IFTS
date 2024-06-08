using System;
using ClinicaSePrice.Enum;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Datos
{
    internal class Turno
    {
        private MySqlConnection sqlCon;

        public Turno()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public void obtenerTurnosDisponibles(DataGridView tablaTurno)
        {
            try
            {
                tablaTurno.DataSource = null;
                MySqlDataReader resultado;
                DataTable dt = new DataTable();
                MySqlCommand comando = new MySqlCommand("sp_consulta_turnos_posibles_x_medico", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("i_fecha_desde", MySqlDbType.Date).Value = new DateTime(2024, 6, 3);
                comando.Parameters.Add("i_fecha_hasta", MySqlDbType.Date).Value = new DateTime(2024, 6, 7);
                comando.Parameters.Add("i_id_medico", MySqlDbType.Int32).Value = 1;

                sqlCon.Open();
                resultado = comando.ExecuteReader();

                if (resultado.HasRows)
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

                
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al cargar la tabla con los turnos disponibles" + error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
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
