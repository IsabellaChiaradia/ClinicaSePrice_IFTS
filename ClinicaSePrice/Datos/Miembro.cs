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
    public class Miembro
    {
        private MySqlConnection sqlCon;
        public Miembro()
        {
            // Inicializa la conexión en el constructor de la clase.
            sqlCon = Conexion.getInstancia().CrearConexion(); //Enlazar la conexión a la base de datos.
        }

        //En este sector podrá encontrar:  Método para agregar un nuevo miembro al club deportivo.
        //Objeto de tipo E_Miembro que contiene la información del nuevo miembro.
        //public string Nuevo_Miembro(E_Miembro miembro)
        //{
        //    string? salida; // Variable para almacenar el resultado de la operación.
            

        //    try
        //    {
              
        //        MySqlCommand comando = new MySqlCommand("NuevoMiembro", sqlCon); Define un nuevo comando SQL almacenado la cual hace referencia
        //        //al procedimiento llamado "NuevoMiembro" ubicada en la base de datos.
        //        comando.CommandType = CommandType.StoredProcedure;

        //        // Asigna los parámetros del miembro al comando SQL.
        //        comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = miembro.Nombre;
        //        comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = miembro.Apellido;
        //        comando.Parameters.Add("Dni", MySqlDbType.VarChar).Value = miembro.DNI;
        //        comando.Parameters.Add("EsSocio", MySqlDbType.Byte).Value = miembro.EsSocio ? 1 : 0;
        //        comando.Parameters.Add("Correo", MySqlDbType.VarChar).Value = miembro.Correo;
        //        comando.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = miembro.Direccion;
        //        comando.Parameters.Add("FNac", MySqlDbType.VarChar).Value = miembro.FechaNac;
        //        comando.Parameters.Add("AptoM", MySqlDbType.Byte).Value = miembro.AptoMedico ? 1 : 0;

        //        MySqlParameter ParCodigo = new MySqlParameter();
        //        ParCodigo.ParameterName = "rta";
        //        ParCodigo.MySqlDbType = MySqlDbType.Int32;
        //        ParCodigo.Direction = ParameterDirection.Output;
        //        comando.Parameters.Add(ParCodigo);

        //        sqlCon.Open(); // Abre la conexión a la base de datos.
        //        comando.ExecuteNonQuery(); // Ejecuta el comando SQL almacenado.
        //        salida = Convert.ToString(ParCodigo.Value); // Obtiene el resultado de la operación.

        //    }
        //    catch (Exception ex)
        //    {
        //        salida = ex.Message; // En caso de error, se captura el mensaje de error.
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open)
        //        { sqlCon.Close(); }; // Se asegura de cerrar la conexión a la base de datos, si está abierta.
        //    }

        //    return salida; // Devuelve el mensaje de salida, indicando el resultado de la operación.
        //}

        public void mostrarMiembros(DataGridView tablaMiembros)
        {
            try
            {
                tablaMiembros.DataSource = null;
                string query = "SELECT * FROM miembro;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);   
                tablaMiembros.DataSource = dt;   
            }
            catch (Exception error)
            {
                MessageBox.Show("No se mostraron los datos de la Base de datos" + error);
            }
        }

    }
}
