using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Datos
{
    internal class Usuario
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string User_email, string User_psw)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion para su posterior ejecución
                //con el fin de poder realizar el inicio de sesión del administrador 
                MySqlCommand comando = new MySqlCommand("sp_ingreso_login", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("correo",MySqlDbType.VarChar).Value = User_email;
                comando.Parameters.Add("psw", MySqlDbType.VarChar).Value = User_psw;
                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader();

                if (resultado.HasRows)
                {
                    // Asumiendo que DataTable tiene columnas: "nombre", "apellido",y  "nomRol"
                    tabla.Load(resultado);
                }
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch (Exception ex)
            {
                throw;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}