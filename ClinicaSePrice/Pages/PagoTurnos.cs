using ClinicaSePrice.Comprobantes;
using ClinicaSePrice.Datos;
using ClinicaSePrice.Entidades;
using ClinicaSePrice.Enum;
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
    public partial class PagoTurnos : UserControl
    {

        private string dniMiembro;
        //private List<E_Actividad> actividades;
        private frmFactura factura;

        //---------------------
        private Turno turnoDB;
        private Paciente pacienteDB;
        private E_Turno? turnoSeleccionado;
        private E_Paciente? pacienteSeleccionado;

        public PagoTurnos()
        {
            InitializeComponent();
            this.turnoDB = new Turno();
            this.pacienteDB = new Paciente();
        }


        // ---------------------------- FUNCIONES ----------------------------



        private void cargarFormaDePago()
        {
            cboFormaPago.Items.Add("Seleccionar forma de pago");
            cboFormaPago.Items.Add("Particular");
            cboFormaPago.Items.Add("Obra Social");
            cboFormaPago.SelectedIndex = 0;
        }


        private double calcularDescuento()
        {
            string formaPagoSeleccionada = cboFormaPago.SelectedItem.ToString();

            if (formaPagoSeleccionada == "Obra Social")
            {
                return (double)DescuentoFormaDePagoEnum.obraSocial / 100.00;

            }
            else
            {
                return 0;
            }

        }


        private void aplicarInteresCuotas(double costo)
        {
            if (costo >= 0)
            {
                double interes = calcularDescuento();
                txtMontoPA.Text = Math.Round((costo * (1 + interes)), 2).ToString();
            }
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void PagoTurno_Load(object sender, EventArgs e)
        {
            cargarFormaDePago();
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnPagarPA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDniPaciente.Text) || txtDniPaciente.Text == "Documento" ||
                string.IsNullOrWhiteSpace(txtMontoPA.Text) || txtMontoPA.Text == "Monto")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string respuesta;
            E_Practica cuota = new E_Practica();

            string monto = txtMontoPA.Text;
            //cuota.Monto = Math.Round(double.Parse(monto), 2);
            /*cuota.FechaPago = dtpPA.Value*/
            ;
            dniMiembro = txtDniPaciente.Text;


            // respuesta = cuotaDB.Pagar(cuota, dniMiembro, 2);  el parametro 2 indica que el pago es de tipo actividad
            respuesta = "1"; // hice esto solo para que compile

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("Se realizó el pago correctamente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    //Cargamos los datos del pago en la grilla
                    //cuotaDB.mostrarPagoExitoso(dtgvActividad, dniMiembro);
                    this.factura = new frmFactura(); // cada vez que pagamos generamos una nueva factura
                    //cargarFactura();
                    btnComprobantePA.Enabled = true;
                }
                else if (codigo == 0)
                {
                    MessageBox.Show("Sólo los NO socios deben pagar por la actividad a realizar", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El miembro no está registrado en el sistema ", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ups! Hubo un error en el pago: " + respuesta, "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnComprobantePA_Click(object sender, EventArgs e)
        {
            factura.Show();
        }


        // ---------------------------- EVENTOS DE COMBOBOX ----------------------------



        // ---------------------------- EVENTOS DE TEXTBOX ----------------------------

        private void txtDniPaciente_Enter(object sender, EventArgs e)
        {
            if (txtDniPaciente.Text == "DNI")
            {
                txtDniPaciente.Text = "";
            }
        }

        private void txtDniPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números (0-9), teclas de control (como borrar, copiar, pegar), y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto evita que se procese el carácter ingresado
            }
        }

        private void txtDniPaciente_Leave(object sender, EventArgs e)
        {
            if (txtDniPaciente.Text == "")
            {
                txtDniPaciente.Text = "DNI";
            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string dni = txtDniPaciente.Text;

            if (dni == "DNI" || string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.pacienteSeleccionado = pacienteDB.BuscarPacientePorDNI(dni);

            if (this.pacienteSeleccionado == null)
            {
                MessageBox.Show("No se encontró el paciente con el DNI ingresado. Regístrelo en Registrar Paciente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDniPaciente.Text = "DNI";
            }
            else
            {
                MessageBox.Show($"Paciente encontrado: {this.pacienteSeleccionado.Nombre} {this.pacienteSeleccionado.Apellido}", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {
            this.turnoSeleccionado = null;

            if (this.pacienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un paciente para traer los turnos asociados",
                                "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            turnoDB.ObtenerTurnosAPagar(this.pacienteSeleccionado.Id, dtgvTurnos);
        }
    }
}
