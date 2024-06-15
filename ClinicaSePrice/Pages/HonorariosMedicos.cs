using ClinicaSePrice.Datos;
using ClinicaSePrice.Entidades;
using ClinicaSePrice.Comprobantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Pages
{
    public partial class HonorariosMedicos : UserControl
    {
        private Medico medicoDatos;
        private DataTable dtHonorarios;
        private int idMedico;

        public HonorariosMedicos()
        {
            InitializeComponent();
            medicoDatos = new Medico();
            dtHonorarios = new DataTable();

            dtHonorarios.Columns.Add("Fecha", typeof(string));
            dtHonorarios.Columns.Add("Honorarios", typeof(decimal));
            dtHonorarios.Columns.Add("Cantidad de Turnos", typeof(int));
        }


        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if (txtDNI.Text == "DNI")
            {
                txtDNI.Text = "";
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números (0-9), teclas de control (como borrar, copiar, pegar), y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto evita que se procese el carácter ingresado
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                txtDNI.Text = "DNI";
            }
        }


        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI válido.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtDNI.Text = "DNI";
                return;
            }

            int idMedico = medicoDatos.ObtenerIdMedicoPorDNI(dni);
            if (idMedico == 0)
            {
                MessageBox.Show("No se encontró ningún médico con el DNI ingresado.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtDNI.Text = "DNI";
                return;
            }

            DateTime fecha = DateTime.Now;
            CargarHonorariosMedicos(idMedico, fecha);
        }

        public void CargarHonorariosMedicos(int idMedico, DateTime fecha)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Honorarios", typeof(decimal));
            dt.Columns.Add("Cantidad de Turnos", typeof(int));

            decimal honorarios = 0;
            int cantidadTurnos = 0;

            try
            {
                honorarios = medicoDatos.CalcularHonorarios(idMedico, fecha.ToString("yyyy-MM-dd"));
                cantidadTurnos = medicoDatos.ObtenerCantidadTurnos(idMedico, fecha.ToString("yyyy-MM-dd"));

                DataRow row = dt.NewRow();
                row["Fecha"] = fecha.ToString("yyyy-MM-dd");
                row["Cantidad de Turnos"] = cantidadTurnos;
                row["Honorarios"] = honorarios;

                dt.Rows.Add(row);

                dtgvHonorarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los honorarios y la cantidad de turnos: " + ex.Message, "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
            if (dtgvHonorarios.SelectedRows.Count > 0)
            {
               
                frmFacturaHonorarios facturaForm = new frmFacturaHonorarios();
                               
                string dni = txtDNI.Text.Trim();                
                medicoDatos.EmitirFactura(dni, facturaForm);                                
                facturaForm.ShowDialog();
                                
                facturaForm.Dispose();
            }
            else
            {
                MessageBox.Show("Seleccione una fila válida en la tabla de honorarios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
