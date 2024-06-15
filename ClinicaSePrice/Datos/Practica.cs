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
    internal class Practica
    {
        private MySqlConnection sqlCon;

        public Practica()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public List<E_Practica> getPracticasXEspecialidad(int idEspecialidad)
        {
            var listaPracticas = new List<E_Practica>();
            try
            {
                var query = "SELECT p.*, e.tipo " +
                            "FROM Practica p " +
                            "INNER JOIN especialidad e ON e.idEspecialidad = p.id_especialidad " +
                            "WHERE e.idEspecialidad = " + idEspecialidad + " " +
                            "ORDER BY p.idPractica";
                var adapter = new MySqlDataAdapter(query, sqlCon);
                var dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    var practica = new E_Practica
                    {
                        IdPractica = Convert.ToInt32(row["idPractica"].ToString()),
                        Descripcion = row["descripcion"].ToString()
                    };


                    listaPracticas.Add(practica);
                };
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al traer la lista de practicas " + error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                };
            }

            return listaPracticas;
        }

        public decimal ObtenerCostoPractica(int idPractica, int idPaciente)
        {
            decimal costo = 0;

            try
            {
                string query = "SELECT costo FROM Practica WHERE idPractica = @idPractica";
                using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
                {
                    comando.Parameters.AddWithValue("@idPractica", idPractica);
                    sqlCon.Open();
                    object result = comando.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        costo = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el costo de la práctica: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return costo;
        }
    }
}
