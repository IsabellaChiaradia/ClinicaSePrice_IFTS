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
    public partial class PagoEstudioClinico : UserControl
    {
        private Cuota cuotaDB;
        private Actividad actividadBD;
        private string dniMiembro;
        private List<E_Actividad> actividades;
        private frmFactura factura;

        public PagoEstudioClinico()
        {
            InitializeComponent();
            this.cuotaDB = new Cuota();
            this.actividadBD = new Actividad();
        }


        // ---------------------------- FUNCIONES ----------------------------

        private void cargarActividades()
        {
            this.actividades = actividadBD.traerActividades();

            cboActividad.Items.Add("Seleccionar Actividad");
            foreach (E_Actividad a in actividades)
            {
                cboActividad.Items.Add(a.Nombre);
            }
            cboActividad.SelectedIndex = 0;
        }


        private void cargarCuotas()
        {
            cboCuotasPA.Items.Add("Cantidad de Cuotas");
            cboCuotasPA.Items.Add("3 cuotas");
            cboCuotasPA.Items.Add("6 cuotas");
            cboCuotasPA.SelectedIndex = 0;
        }

        private void cargarFactura()
        {
            factura.actividad = cboActividad.SelectedItem.ToString();
            factura.interes = (calcularInteresCuotas() * 100).ToString() + "%";

            if (cbxTarjetaPA.Checked)
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
            string cantCuotasSeleccionadas = cboCuotasPA.SelectedItem.ToString();

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

        private double capturarCostoActivSeleccionada()
        {
            string actSeleccionada = cboActividad.SelectedItem.ToString();
            double costo = 0;

            foreach (E_Actividad a in actividades)
            {
                if (actSeleccionada == "Seleccionar Actividad")
                {
                    costo = -1;
                    break;
                }
                else if (actSeleccionada == a.Nombre)
                {
                    costo = a.Costo;
                    break;
                }
            }

            return costo;
        }

        private void aplicarInteresCuotas(double costo)
        {
            if (costo >= 0)
            {
                double interes = calcularInteresCuotas();
                txtMontoPA.Text = Math.Round((costo * (1 + interes)), 2).ToString();
            }
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void PagoActividad_Load(object sender, EventArgs e)
        {
            cargarActividades();
            cargarCuotas();
        }


        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnPagarPA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoPA.Text) || txtDocumentoPA.Text == "Documento" ||
                string.IsNullOrWhiteSpace(txtMontoPA.Text) || txtMontoPA.Text == "Monto")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string respuesta;
            E_Cuota cuota = new E_Cuota();

            string monto = txtMontoPA.Text;
            cuota.Monto = Math.Round(double.Parse(monto), 2);
            cuota.FechaPago = dtpPA.Value;
            dniMiembro = txtDocumentoPA.Text;


            respuesta = cuotaDB.Pagar(cuota, dniMiembro, 2); // el parametro 2 indica que el pago es de tipo actividad

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("Se realizó el pago correctamente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    //Cargamos los datos del pago en la grilla
                    cuotaDB.mostrarPagoExitoso(dtgvActividad, dniMiembro);
                    this.factura = new frmFactura(); // cada vez que pagamos generamos una nueva factura
                    cargarFactura();
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

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            double costo = capturarCostoActivSeleccionada();
            if (costo == -1)
            {
                txtMontoPA.Text = "Monto";
            }
            else if (costo >= 0)
            {
                // Antes de colocar el monto final llamo a la siguiente funcion por si ya han seleccionado pago en tarjeta
                aplicarInteresCuotas(costo);
            }
        }

        private void cboCuotasPA_SelectedIndexChanged(object sender, EventArgs e)
        {
            double costo = capturarCostoActivSeleccionada();
            aplicarInteresCuotas(costo);
        }


        // ---------------------------- EVENTOS DE CHECKBOX ----------------------------

        private void cbxEfectivoPA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEfectivoPA.Checked)
            {
                cboCuotasPA.SelectedIndex = 0;
                cboCuotasPA.Enabled = false;
                cbxTarjetaPA.Checked = false;
                double costo = capturarCostoActivSeleccionada();
                if (costo >= 0)
                {
                    txtMontoPA.Text = costo.ToString();
                }
            }
        }

        private void cbxTarjetaPA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTarjetaPA.Checked)
            {
                cbxEfectivoPA.Checked = false;
                cboCuotasPA.Enabled = true;
            }
        }


        // ---------------------------- EVENTOS DE TEXTBOX ----------------------------

        private void txtDocumentoPA_Enter(object sender, EventArgs e)
        {
            if (txtDocumentoPA.Text == "Documento")
            {
                txtDocumentoPA.Text = "";
            }
        }

        private void txtDocumentoPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números (0-9), teclas de control (como borrar, copiar, pegar), y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto evita que se procese el carácter ingresado
            }
        }

        private void txtDocumentoPA_Leave(object sender, EventArgs e)
        {
            if (txtDocumentoPA.Text == "")
            {
                txtDocumentoPA.Text = "Documento";
            }
        }


    }
}
