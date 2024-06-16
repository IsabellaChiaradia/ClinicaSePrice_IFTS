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


        private void calcularMontoFinalDelTurnoSeleccionado(double? costo)
        {
            if (costo != null)
            {
                double descuento = calcularDescuento();
                txtMontoFinal.Text = Math.Round((double)(costo * (1 - descuento)), 2).ToString();
            }


        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void PagoTurno_Load(object sender, EventArgs e)
        {
            cargarFormaDePago();
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (this.turnoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar el turno que quiere pagar", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(this.turnoSeleccionado.IdTurno == -1)
            {
                MessageBox.Show("El turno seleccionado ya ha sido acreditado", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var montoFinal = Convert.ToDouble(txtMontoFinal.Text);

            turnoDB.PagarTurno(this.turnoSeleccionado.IdTurno, montoFinal);
            
            MessageBox.Show("Se realizó el pago correctamente", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);


            
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
            txtMontoFinal.Text = "Monto";

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

        private void dtgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = this.dtgvTurnos.Rows[e.RowIndex];
                DataRow? filaOriginal = filaSeleccionada.Tag as DataRow;


                if (filaOriginal != null)
                {
                    this.turnoSeleccionado = new E_Turno();
                    Boolean isTurnoAcreditado = (bool)filaOriginal["acreditado"];
                    if (!isTurnoAcreditado)
                    {
                        // Obtener los valores de la fila original
                        this.turnoSeleccionado.IdTurno = (int)filaOriginal["idTurno"];
                        this.turnoSeleccionado.Practica = new E_Practica();
                        this.turnoSeleccionado.Practica.Costo = Convert.ToDouble(filaOriginal["costo"]);
                        calcularMontoFinalDelTurnoSeleccionado(this.turnoSeleccionado.Practica.Costo);

                    }
                    else
                    {
                        this.turnoSeleccionado.IdTurno = -1; // esto significa que el turno seleccionado está acreditado
                        txtMontoFinal.Text = "Monto";

                    }


                }
            }
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formaPagoSeleccionada = cboFormaPago.SelectedItem.ToString();

            if (this.turnoSeleccionado != null)
            {
                calcularMontoFinalDelTurnoSeleccionado(this.turnoSeleccionado.Practica.Costo);
            }
        }
    }
}
