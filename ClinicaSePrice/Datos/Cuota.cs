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
    public class Cuota
    {
        private MySqlConnection sqlCon;

        public Cuota()
        {
            this.sqlCon = Conexion.getInstancia().CrearConexion();
        }


        public void mostrarPagoExitoso(DataGridView tablaPago, string dni)
        {
            try
            {
                tablaPago.DataSource = null;
                string query = "SELECT m.Nombre, m.Apellido, c.Monto, " 
                    + " c.FechaVenc AS 'Fecha de Vencimiento' " 
                    + " FROM miembro m " 
                    + " INNER JOIN cuota c ON c.IDMiembro = m.IDMiembro " 
                    + " WHERE m.DNI = " + dni
                    + " ORDER BY IDCuota DESC, c.FechaPago DESC "
                    + " LIMIT 1;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPago.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al cargar la tabla con el último pago miembro " + error);
            }
        }

        public void mostrarSociosMorosos(DataGridView tabla)
        {
            try
            {
                tabla.DataSource = null;
                string query = "SELECT m.Nombre, m.Apellido, m.DNI, m.Correo, MAX(c.FechaVenc) AS 'Fecha de Vencimiento'"
                    + " FROM miembro m "
                    + " INNER JOIN cuota c ON c.IDMiembro = m.IDMiembro "
                    + " WHERE m.EsSocio "
                    + " GROUP BY m.IDMiembro "
                    + " HAVING MAX(c.FechaVenc) <= CURRENT_DATE"
                    + " ORDER BY MAX(c.FechaVenc); ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al cargar el listado de los socios morosos " + error);
            }
        }


        public void emitirFactura(string dni, frmFactura factura)
        {
            try
            {
                
                string query = "SELECT m.Nombre, m.Apellido, m.DNI, m.EsSocio, c.FechaPago, c.FechaVenc, c.Monto "
                    + " FROM miembro m "
                    + " INNER JOIN cuota c ON c.IDMiembro = m.IDMiembro "
                    + " WHERE m.DNI = " + dni
                    + " ORDER BY IDCuota DESC, c.FechaPago DESC "
                    + " LIMIT 1;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    factura.nombre = row["Nombre"].ToString();
                    factura.apellido = row["Apellido"].ToString();
                    factura.dni = row["DNI"].ToString();
                    factura.fechaPago = Convert.ToDateTime(row["FechaPago"]).ToString("dd/MM/yyyy");
                    factura.fechaVenc = Convert.ToDateTime(row["FechaVenc"]).ToString("dd/MM/yyyy");
                    factura.monto = "$" + row["Monto"].ToString();
                    if (Convert.ToInt32(row["EsSocio"]) == 1)
                    {
                        factura.tipoMiembro = "Socio";
                    }
                    else
                    {
                        factura.tipoMiembro = "No Socio";
                    }
                    
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ups! Hubo un error al emitir la factura " + error);
            }
        }

    }
}
