using ClinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Datos
{
    public class Actividad
    {
        private MySqlConnection sqlCon;

        public Actividad() 
        { 
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public List<E_Actividad> traerActividades()
        {
                List<E_Actividad> listaActividades = new List<E_Actividad>();
            try
            {
                string query = "SELECT IDActiv, Nombre, CupoMax, Costo "
                    + " FROM actividad ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {                  
                    E_Actividad actividad = new E_Actividad();

                    actividad.IDMiembro = Convert.ToInt32(row["IDActiv"].ToString());
                    actividad.Nombre = row["Nombre"].ToString();
                    actividad.CupoMax = Convert.ToInt32(row["CupoMax"].ToString());
                    actividad.Costo = Convert.ToDouble(row["Costo"].ToString());

                    listaActividades.Add(actividad);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al traer las actividades del club " + error);
            }

            return listaActividades;
        }
    }
}
