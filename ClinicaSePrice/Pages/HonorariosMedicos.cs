using ClinicaSePrice.Controladores;
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
        private ControladorHonorarios controladorHonorarios;

        public HonorariosMedicos()
        {
            InitializeComponent();
            controladorHonorarios = new ControladorHonorarios();

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
        private void HonorariosMedicos_Load(object sender, EventArgs e)
        {
            cargarTipoLiquidacion();
        }
        private void cargarTipoLiquidacion()
        {

            var tiposLiquidacion = new List<TipoLiquidacion>
    {
            new TipoLiquidacion(0, "Seleccione Liquidación"),
            new TipoLiquidacion(1, "Diaria"),
            new TipoLiquidacion(2, "Semanal"),
            new TipoLiquidacion(3, "Mensual")
    };

            cmbTipoLiquidacion.DisplayMember = "Nombre";
            cmbTipoLiquidacion.ValueMember = "Id";
            cmbTipoLiquidacion.DataSource = tiposLiquidacion;


        }

        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string tipoLiquidacion = cmbTipoLiquidacion.SelectedItem.ToString();

            if (tipoLiquidacion != "Seleccione Liquidación")
            {
                controladorHonorarios.CargarHonorariosMedico(dtgvHonorarios, dni, tipoLiquidacion);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de liquidación.");
            }
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

        private void cmbTipoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el tipo de liquidación seleccionado
            TipoLiquidacion tipoSeleccionado = (TipoLiquidacion)cmbTipoLiquidacion.SelectedItem;

            // Validar si se seleccionó un tipo de liquidación válido
            if (tipoSeleccionado != null && tipoSeleccionado.Id != 0)
            {
                // Aquí puedes proceder con el código que debe ejecutarse cuando se selecciona un tipo válido
                // Por ejemplo, puedes habilitar otros controles o realizar otras acciones necesarias.
            }
            else
            {
                // Mostrar mensaje de error si no se seleccionó un tipo de liquidación válido
                MessageBox.Show("Seleccione un tipo de liquidación válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
