using ClinicaSePrice.Datos;
using ClinicaSePrice.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Pages
{
    public partial class RegistrarPaciente : UserControl
    {
        private Miembro miembroDB;
        public RegistrarPaciente()
        {
            InitializeComponent();
            this.miembroDB = new Miembro();
        }


        // ---------------------------- FUNCIONES ----------------------------

        private void limpiarCampos()
        {
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDni.Text = "DNI";
            txtCorreo.Text = "Correo";
            txtDomicilio.Text = "Domicilio";
            txtFechaNacimiento.Text = "dd/mm/aaaa";
        }

        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------



        // ---------------------------- EVENTOS DE BOTONES ----------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //validamos que no existan campos vacíos o sin rellenar antes de generar la inscripción 
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == "Nombre" ||
                string.IsNullOrWhiteSpace(txtApellido.Text) || txtApellido.Text == "Apellido" ||
                string.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text == "DNI" ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) || txtCorreo.Text == "Correo" ||
                string.IsNullOrWhiteSpace(txtDomicilio.Text) || txtDomicilio.Text == "Domicilio" ||
                string.IsNullOrWhiteSpace(txtFechaNacimiento.Text) || txtFechaNacimiento.Text == "dd/mm/aaaa")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string respuesta;
            E_Miembro miembro = new E_Miembro();

            miembro.Nombre = txtNombre.Text;
            miembro.Apellido = txtApellido.Text;
            miembro.DNI = txtDni.Text;
            miembro.Correo = txtCorreo.Text;
            miembro.Direccion = txtDomicilio.Text;
            miembro.FechaNac = txtFechaNacimiento.Text;


            //Tener en cuenta que, en base a la respuesta que ejecuta el procedimiento almacenado posteriormente evocado dentro
            //de la clase Miembro, serán las siguientes lineas de código mostrando si fue o no exitosa la carga.
            respuesta = this.miembroDB.Nuevo_Miembro(miembro);

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("EL PACIENTE YA EXISTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se dió de alta con éxito el paciente con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ups! Hubo un error con la alta del paciente", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        // ---------------------------- EVENTOS DE TEXTBOX ----------------------------

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
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
                txtDni.Text = "DNI";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void txtDomicilio_Enter(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "Domicilio")
            {
                txtDomicilio.Text = "";
            }
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "")
            {
                txtDomicilio.Text = "Domicilio";
            }
        }

        private void txtFechaNacimiento_Enter(object sender, EventArgs e)
        {
            if (txtFechaNacimiento.Text == "dd/mm/aaaa")
            {
                txtFechaNacimiento.Text = "";
            }
        }

        private void txtFechaNacimiento_Leave(object sender, EventArgs e)
        {
            if (txtFechaNacimiento.Text == "")
            {
                txtFechaNacimiento.Text = "dd/mm/aaaa";
            }       
        }

        private void bntLimpiarRP_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
