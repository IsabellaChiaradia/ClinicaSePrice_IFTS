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

namespace ClinicaSePrice.Pages
{
    public partial class ControlInsumos : UserControl
    {
        public ControlInsumos()
        {
            InitializeComponent();
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void CuotasVencidas_Load(object sender, EventArgs e)
        {
            //Cuota cuotaDB = new Cuota();
            //cuotaDB.mostrarSociosMorosos(dtgvCuotasVenc);


        }
        // ---------------------------- EVENTOS DEL BOTON DEL FORM ----------------------------
        private void btnNotificar_Click(object sender, EventArgs e)
        {

            if (dtgvCuotasVenc.SelectedRows.Count > 0)
            {
                string nombreSocio = Convert.ToString(dtgvCuotasVenc.SelectedRows[0].Cells["Nombre"].Value);
                string apellidoSocio = Convert.ToString(dtgvCuotasVenc.SelectedRows[0].Cells["Apellido"].Value);
                string dniSocio = Convert.ToString(dtgvCuotasVenc.SelectedRows[0].Cells["DNI"].Value);
                string correoSocio = Convert.ToString(dtgvCuotasVenc.SelectedRows[0].Cells["Correo"].Value);
                string fechaVencimiento = Convert.ToString(dtgvCuotasVenc.SelectedRows[0].Cells["Fecha de Vencimiento"].Value);


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
