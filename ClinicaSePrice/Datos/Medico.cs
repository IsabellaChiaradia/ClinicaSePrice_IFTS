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
    }
}
