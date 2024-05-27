using ClinicaSePrice.Comprobantes;
using ClinicaSePrice.Datos;
using ClinicaSePrice.Entidades;
using ClinicaSePrice.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_ClinicaSePrice.Pages
{
    public partial class PagoAtencionMedica : UserControl
    {

        private Cuota cuotaDB;
        private string dniMiembro;
        private double montoEfectivo;
        private frmFactura factura;

        public PagoAtencionMedica()
        {
            InitializeComponent();
            this.cuotaDB = new Cuota();
        }


        // ---------------------------- FUNCIONES ----------------------------

        private void cargarCuotas()
        {
            cboCuotas.Items.Add("Cantidad de Cuotas");
            cboCuotas.Items.Add("3 cuotas");
            cboCuotas.Items.Add("6 cuotas");
            cboCuotas.SelectedIndex = 0;
        }

        private void cargarFactura()
        {
            factura.interes = (calcularInteresCuotas() * 100).ToString() + "%";

            if (cbxTarjeta.Checked)
            {
                factura.formaDePago = "Tarjeta";
            }
            else
            {
                factura.formaDePago = "Efectivo";
            }

            cuotaDB.emitirFactura(dniMiembro, factura);
        }

        private double calcularInteresCuotas()
        {
            string cantCuotasSeleccionadas = cboCuotas.SelectedItem.ToString();

            if (cantCuotasSeleccionadas == "3 cuotas")
            {
                return (double)InteresesCuotasEnum.tresCuotas / 100.00;

            }
            else if (cantCuotasSeleccionadas == "6 cuotas")
            {
                return (double)InteresesCuotasEnum.seisCuotas / 100.00;

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
                double interes = calcularInteresCuotas();
                txtMonto.Text = Math.Round((costo * (1 + interes)), 2).ToString();
            }
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void PagoMensualCuota_Load(object sender, EventArgs e)
        {
            cargarCuotas();
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text == "Documento" ||
                string.IsNullOrWhiteSpace(txtMonto.Text) || txtMonto.Text == "Monto")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string respuesta;
            E_Cuota cuota = new E_Cuota();

            string monto = txtMonto.Text.Replace('.', ',');
            cuota.Monto = Math.Round(double.Parse(monto), 2);
            cuota.FechaPago = dtpPago.Value;
            dniMiembro = txtDni.Text;

            respuesta = cuotaDB.Pagar(cuota, dniMiembro, 1); // el parametro 1 indica que el pago es de tipo mensual

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 3)
                {
                    MessageBox.Show("El socio ya ha pagado la cuota del mes actual", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (codigo == 1)
                {
                    MessageBox.Show("Se realizó el pago correctamente", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Cargamos los datos del pago en la grilla
                    cuotaDB.mostrarPagoExitoso(dgtvPagoRealizado, dniMiembro);

                    this.factura = new frmFactura(); // cada vez que pagamos generamos una nueva factura
                    cargarFactura();
                    btnComprobante.Enabled = true;
                }
                else if (codigo == 0)
                {
                    MessageBox.Show("Sólo los socios pueden pagar la cuota mensual", "AVISO DEL SISTEMA",
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


        private void btnComprobante_Click(object sender, EventArgs e)
        {
            factura.Show();
        }


        // ---------------------------- EVENTOS DE COMBOBOX ----------------------------

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMonto.Text) && txtMonto.Text != "Monto")
            {
                aplicarInteresCuotas(montoEfectivo);
            }
        }


        // ---------------------------- EVENTOS DE CHECKBOX ----------------------------

        private void cbxEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEfectivo.Checked)
            {
                cboCuotas.SelectedIndex = 0;
                cboCuotas.Enabled = false;
                cbxTarjeta.Checked = false;
                txtMonto.Text = montoEfectivo.ToString();
            }
        }

        private void cbxTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTarjeta.Checked)
            {
                cbxEfectivo.Checked = false;
                cboCuotas.Enabled = true;
            }
        }


        // ---------------------------- EVENTOS DE TEXTBOX ----------------------------

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "Documento")
            {
                txtDni.Text = "";
            }
        }
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números (0-9), teclas de control (como borrar, copiar, pegar), y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto evita que se procese el carácter ingresado
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "Documento";
            }
        }

        private void txtMonto_Enter(object sender, EventArgs e)
        {
            if (txtMonto.Text == "Monto")
            {
                txtMonto.Text = "";
            }

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números (0-9), teclas de control (como borrar, copiar, pegar), y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto evita que se procese el carácter ingresado
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                txtMonto.Text = "Monto";
            }
            else
            {

                string monto = txtMonto.Text.Replace('.', ','); // TODO VALIDAR QUE EL VALOR INTRODUCIDO SEA NUMÉRICO
                montoEfectivo = Math.Round(double.Parse(monto), 2);

                // Modifico el monto si ya han seleccionado pago en tarjeta
                if (!string.IsNullOrWhiteSpace(txtMonto.Text) && txtMonto.Text != "Monto")
                {
                    aplicarInteresCuotas(montoEfectivo);
                }
            }
        }
    }
}
