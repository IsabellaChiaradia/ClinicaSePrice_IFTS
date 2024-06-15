using ClinicaSePrice.Datos;
using ClinicaSePrice.Entidades;
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

        public HonorariosMedicos()
        {
            InitializeComponent();
            medicoDatos = new Medico();

        }


        public class TipoLiquidacion
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public TipoLiquidacion(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
            }
        }       
        

        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;            
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
                return;
            }

            int idMedico = medicoDatos.ObtenerIdMedicoPorDNI(dni);
            if (idMedico == 0)
            {
                MessageBox.Show("No se encontró ningún médico con el DNI ingresado.","AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            DateTime fecha = DateTime.Now;
            CargarHonorariosMedicos(idMedico, fecha);
        }

        private void CargarHonorariosMedicos(int idMedico, DateTime fecha)
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
    }
}
