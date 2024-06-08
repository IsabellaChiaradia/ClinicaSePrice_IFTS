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
    internal class Especialidad
    {
        private MySqlConnection sqlCon;

        public Especialidad()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public List<E_Especialidad> getEspecialidades()
        {
            var listaEspecialidades = new List<E_Especialidad>();
            try
            {
                var query = "SELECT * FROM especialidad ORDER BY idEspecialidad";
                var adapter = new MySqlDataAdapter(query, sqlCon);
                var dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    var especialidad = new E_Especialidad
                    {
                        IdEspecialidad = Convert.ToInt32(row["idEspecialidad"].ToString()),
                        Tipo = row["tipo"].ToString()
                    };


                    listaEspecialidades.Add(especialidad);
                };
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al traer la lista de especialidades" + error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { 
                    sqlCon.Close(); 
                };
            }

            return listaEspecialidades;
        }
    }
}
