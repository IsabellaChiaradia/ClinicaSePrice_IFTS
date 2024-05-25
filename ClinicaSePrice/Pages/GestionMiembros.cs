using ClinicaSePrice.Comprobantes;
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

namespace Dashboard_ClinicaSePrice.pesañas
{//----------------------------TERCERA PANTALLA (PAGINA)-----------------------------//
 //-------------------------------------------------------------------------//
 // En este sector se encontrara con el codigo de la tercera parte, siendo una pagina de navegación en la cual prodrá visualizar
 // un formulario de carga de datos del futuro miembro y los botones que ejecutan la accion de carga, en el sector derecho se visualiza 
 //una ventana correspondiente a un data grid, el mismo sera desarrollado a futuro para visualizar la lista de miembros activos
 //Aqui se podra observar ademas, eventos de limpieza de textbox.
 //Es importante tener en cuenta que, antes de seguir en esta sección del codigo se DEBE observar dentro de la carpeta "Datos"
 //El codigo de Miembro para visualizar la logica de la carga a su vez en la carpeta "Entidades" los atributos que posee el futuro miembro
 //para ser cargado mediante el sistema a la base de datos.
 //A continuación se detalla en el código:
 //-------------------------------------------------------------------------//
    public partial class GestionMiembros : UserControl
    {
        private Miembro miembroDB;
        private FormCarnet carnet;
        public GestionMiembros()
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
            cbxEsSocio.Checked = false;
        }


        // ---------------------------- EVENTOS DEL FORMULARIO ----------------------------

        private void GestionMiembros_Load(object sender, EventArgs e)
        {
            this.miembroDB.mostrarMiembros(dgtvListaSocios);
        }


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
            miembro.EsSocio = cbxEsSocio.Checked;
            miembro.Correo = txtCorreo.Text;
            miembro.Direccion = txtDomicilio.Text;
            miembro.FechaNac = txtFechaNacimiento.Text;
            miembro.AptoMedico = cbxAptoFisico.Checked;


            //Tener en cuenta que, en base a la respuesta que ejecuta el procedimiento almacenado posteriormente evocado dentro
            //de la clase Miembro, serán las siguientes lineas de código mostrando si fue o no exitosa la carga.
            respuesta = this.miembroDB.Nuevo_Miembro(miembro);

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("EL MIEMBRO YA EXISTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se dió de alta con éxito el miembro con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ups! Hubo un error con la alta del miembro", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            //actualizamos la grilla luego de registrar un nuevo miembro
            this.miembroDB.mostrarMiembros(dgtvListaSocios);
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

        private void btnPrintCarnet_Click(object sender, EventArgs e)
        {
            if (dgtvListaSocios.SelectedRows.Count > 0)
            {
                string nombreSocio = Convert.ToString(dgtvListaSocios.SelectedRows[0].Cells["Nombre"].Value);
                string apellidoSocio = Convert.ToString(dgtvListaSocios.SelectedRows[0].Cells["Apellido"].Value);
                string dniSocio = Convert.ToString(dgtvListaSocios.SelectedRows[0].Cells["DNI"].Value);
                string idSocio = Convert.ToString(dgtvListaSocios.SelectedRows[0].Cells["IDMiembro"].Value);
                string correoSocio = Convert.ToString(dgtvListaSocios.SelectedRows[0].Cells["Correo"].Value);
                string fechaInscripcion = DateTime.Now.ToString("dd/MM/yyyy");

                bool esSocio = Convert.ToBoolean(dgtvListaSocios.SelectedRows[0].Cells["EsSocio"].Value);

                if (esSocio)
                {
                    FormCarnet carnet = new FormCarnet(nombreSocio, apellidoSocio, dniSocio, idSocio, correoSocio, fechaInscripcion);
                    carnet.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El miembro seleccionado no es un socio, solo los socios pueden tener carnet.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un miembro antes de imprimir el carnet.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxAptoFisico_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxAptoFisico.Checked)
            {
                MessageBox.Show("El apto físico es obligatorio para la inscripción.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAptoFisico.Checked = true;
            }
        }
    }
}
