using ClinicaSePrice.Comprobantes;
using ClinicaSePrice.Datos;
using ClinicaSePrice.Entidades;
using ClinicaSePrice.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    public partial class GestionTurnos : UserControl
    {
        private FormCarnet carnet;
        public GestionTurnos()
        {
            InitializeComponent();
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

        private void txtDniGestion_Enter(object sender, EventArgs e)
        {
            if (txtDniGestion.Text == "DNI")
            {
                txtDniGestion.Text = "";
            }

        }
        private void txtDniGestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números (0-9), teclas de control (como borrar, copiar, pegar), y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto evita que se procese el carácter ingresado
            }

        }

        private void txtDniGestion_Leave(object sender, EventArgs e)
        {
            if (txtDniGestion.Text == "")
            {
                txtDniGestion.Text = "DNI";
            }

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            RegistrarPaciente uc = new RegistrarPaciente();
        }
    }
}
