using ClinicaSePrice.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using ClinicaSePrice.Entidades;

namespace ClinicaSePrice.Pages
{
    public partial class ControlInsumos : UserControl
    {
        public ControlInsumos()
        {
            InitializeComponent();
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void ControlInsumos_Load(object sender, EventArgs e)
        {
            var insumoDatos = new Insumo();
            List<E_Insumo> insumos = insumoDatos.GetInsumosOrdenados();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("StockMinimo");

            foreach (var insumo in insumos)
            {
                dt.Rows.Add(insumo.IdInsumo, insumo.Nombre, insumo.Cantidad, insumo.StockMinimo);
            }

            dtgvControlInsumos.DataSource = dt;
        }


        // ---------------------------- EVENTOS DEL BOTON DEL FORM ----------------------------
        private void btnNotificar_Click(object sender, EventArgs e)
        {

            if (dtgvControlInsumos.SelectedRows.Count > 0)
            {
                string nombreSocio = Convert.ToString(dtgvControlInsumos.SelectedRows[0].Cells["Nombre"].Value);
                string apellidoSocio = Convert.ToString(dtgvControlInsumos.SelectedRows[0].Cells["Apellido"].Value);
                string dniSocio = Convert.ToString(dtgvControlInsumos.SelectedRows[0].Cells["DNI"].Value);
                string correoSocio = Convert.ToString(dtgvControlInsumos.SelectedRows[0].Cells["Correo"].Value);
                string fechaVencimiento = Convert.ToString(dtgvControlInsumos.SelectedRows[0].Cells["Fecha de Vencimiento"].Value);


                string mensaje = $"Estimado {nombreSocio} {apellidoSocio},\n\n" +
                    $"Le informamos que su cuota vencida con fecha de vencimiento {fechaVencimiento} está pendiente de pago. " +
                    $"Por favor, realice el pago correspondiente lo antes posible.\n\n" +
                    "Atentamente,\nFitNet Club";


                string correoRemitente = "amourxvos@gmail.com";
                string contraseñaRemitente = "jlcu gopb gqks mnch";
                string asunto = "Aviso de Cuota Vencida";

                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(correoRemitente, contraseñaRemitente),
                    EnableSsl = true
                };


                MailMessage mensajeCorreo = new MailMessage(correoRemitente, correoSocio, asunto, mensaje);

                try
                {

                    clienteSmtp.Send(mensajeCorreo);
                    MessageBox.Show("Correo electrónico enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar el correo electrónico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mensajeCorreo.Dispose();
                }

            }
        }
    }
}
