using ClinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClinicaSePrice.Datos
{
    public class Paciente
    {
        private MySqlConnection sqlCon;

        public Paciente()
        {
            sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public string RegistrarPaciente(E_Paciente paciente)
        {
            string salida;

            try
            {
                MySqlCommand comando = new MySqlCommand("sp_alta_paciente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("i_nombre", MySqlDbType.VarChar).Value = paciente.Nombre;
                comando.Parameters.Add("i_apellido", MySqlDbType.VarChar).Value = paciente.Apellido;
                comando.Parameters.Add("i_n_documento", MySqlDbType.VarChar).Value = paciente.NroDoc;
                comando.Parameters.Add("i_correo", MySqlDbType.VarChar).Value = paciente.Email;
                comando.Parameters.Add("i_fecha_nac", MySqlDbType.Date).Value = paciente.FechaNac;
                comando.Parameters.Add("i_n_telefono", MySqlDbType.VarChar).Value = "123456789";
                comando.Parameters.Add("i_domicilio", MySqlDbType.VarChar).Value = paciente.Domicilio;
                comando.Parameters.Add("i_obra_social", MySqlDbType.VarChar).Value = "Obra Social";

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return salida;
        }
    }
}
