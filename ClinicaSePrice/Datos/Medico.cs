using ClinicaSePrice.Comprobantes;
using ClinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Datos
{
    internal class Medico
    {
        private MySqlConnection sqlCon;
        public Medico()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public List<E_Medico> getMedicosXEspecialidad(int idEspecialidad)
        {
            var listaMedicos = new List<E_Medico>();
            try
            {
                var query = "SELECT m.*, e.tipo " +
                            "FROM Medico m " +
                            "INNER JOIN especialidad e ON e.idEspecialidad = m.id_especialidad " +
                            "WHERE e.idEspecialidad = " + idEspecialidad + " " +
                            "ORDER BY m.idMedico";
                var adapter = new MySqlDataAdapter(query, sqlCon);
                var dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    var Medico = new E_Medico
                    {
                        Id = Convert.ToInt32(row["idMedico"].ToString()),
                        Nombre = row["nombre"].ToString(),
                        Apellido = row["apellido"].ToString(),

                    };


                    listaMedicos.Add(Medico);
                };
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al traer la lista de medicos" + error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                };
            }

            return listaMedicos;
        }

        public int ObtenerIdMedicoPorDNI(string dni)
        {
            int idMedico = 0;
            try
            {
                sqlCon.Open();
                string query = "SELECT idMedico FROM medico WHERE nDocumento = @dni";
                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idMedico = Convert.ToInt32(reader["idMedico"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del médico: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return idMedico;
        }

        public decimal CalcularHonorarios(int idMedico, string fecha)
        {
            decimal totalHonorarios = 0;

            try
            {
                using (MySqlConnection con = Conexion.getInstancia().CrearConexion())
                {
                    con.Open();

                    // Consulta para obtener los turnos del médico en la fecha especificada
                    string query = @"
                    SELECT t.idTurno, p.costo
                    FROM turno t
                    INNER JOIN practica p ON t.id_practica = p.idPractica
                    WHERE t.id_medico = @idMedico AND t.fechaAtencion = @fecha";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@fecha", fecha);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal costoPractica = Convert.ToDecimal(reader["costo"]);
                            totalHonorarios += costoPractica;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular los honorarios: " + ex.Message);
            }

            return totalHonorarios;
        }

        public int ObtenerCantidadTurnos(int idMedico, string fecha)
        {
            int cantidadTurnos = 0;

            try
            {
                using (MySqlConnection con = Conexion.getInstancia().CrearConexion())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM turno WHERE id_medico = @idMedico AND fechaAtencion = @fecha", con);
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@fecha", fecha);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        cantidadTurnos = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la cantidad de turnos del médico: " + ex.Message);
            }

            return cantidadTurnos;
        }

        public void EmitirFactura(string dni, frmFacturaHonorarios factura)
        {
            try
            {                
                string query = "SELECT m.idMedico, m.nombre, m.apellido, m.nDocumento, e.tipo AS Especialidad "
                             + "FROM medico m "
                             + "INNER JOIN especialidad e ON e.idEspecialidad = m.id_especialidad "
                             + "WHERE m.nDocumento = @dni;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                adapter.SelectCommand.Parameters.AddWithValue("@dni", dni);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];                                        
                    int idMedico = Convert.ToInt32(row["idMedico"]);
                                        
                    decimal honorarios = CalcularHonorarios(idMedico, DateTime.Now.ToString("yyyy-MM-dd"));
                    int cantidadTurnos = ObtenerCantidadTurnos(idMedico, DateTime.Now.ToString("yyyy-MM-dd"));
                                        
                    if (cantidadTurnos == 0)
                    {
                        honorarios = 0;
                    }

                    factura.nombre = row["nombre"].ToString();
                    factura.apellido = row["apellido"].ToString();
                    factura.dni = row["nDocumento"].ToString();
                    factura.especialidad = row["Especialidad"].ToString();
                    factura.fechaPago = DateTime.Now.ToString("dd/MM/yyyy");
                    factura.cantTurnos = cantidadTurnos.ToString();
                    factura.monto = "$" + honorarios.ToString("F2");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al emitir la factura " + error);
            }
        }
    }
}
