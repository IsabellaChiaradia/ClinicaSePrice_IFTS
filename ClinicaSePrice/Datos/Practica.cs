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
    }
}
