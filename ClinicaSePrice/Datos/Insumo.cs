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
    internal class Insumo
    {
        private MySqlConnection sqlCon;

        public Insumo()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }

        public List<E_Insumo> GetInsumosOrdenados()
        {
            var listaInsumos = new List<E_Insumo>();
            try
            {
                var query = "SELECT idInsumo, nombre, cantidad, stock_minimo " +
                            "FROM insumo " +
                            "ORDER BY (cantidad - stock_minimo) ASC";

                var adapter = new MySqlDataAdapter(query, sqlCon);
                var dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    var insumo = new E_Insumo
                    {
                        IdInsumo = Convert.ToInt32(row["idInsumo"]),
                        Nombre = row["nombre"].ToString(),
                        Cantidad = Convert.ToInt32(row["cantidad"]),
                        StockMinimo = Convert.ToInt32(row["stock_minimo"])
                    };

                    listaInsumos.Add(insumo);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al traer la lista de insumos: " + error.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return listaInsumos;
        }
    }
}
