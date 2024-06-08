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
{
    public partial class GestionTurnos : UserControl
    {
        private FormCarnet? comprobanteTurno;
        private Turno turnoDB;
        private Especialidad especialidadDB;
        private E_Especialidad especialidadSeleccionada;

        public GestionTurnos()
        {
            InitializeComponent();
            this.turnoDB = new Turno();
            this.especialidadDB = new Especialidad();
        }

        private void GestionTurnos_Load(object sender, EventArgs e)
        {
            cargarEspecialidades();
        }

        private void cargarEspecialidades()
        {
            var especialidades = new List<E_Especialidad>();

            especialidades.Add(new E_Especialidad(0, "Seleccionar Especialidad"));

            especialidades.AddRange(this.especialidadDB.getEspecialidades());

            cboEspecialidad.DisplayMember = "Tipo";
            cboEspecialidad.ValueMember = "IdEspecialidad";
            cboEspecialidad.DataSource = especialidades;

            cboEspecialidad.SelectedIndex = 0;

        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedItem != null)
            {
                this.especialidadSeleccionada = (E_Especialidad)cboEspecialidad.SelectedItem;

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

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (dgtvTurnos.SelectedRows.Count > 0)
            {
                string? nombreSocio = Convert.ToString(dgtvTurnos.SelectedRows[0].Cells["Nombre"].Value);
                string? apellidoSocio = Convert.ToString(dgtvTurnos.SelectedRows[0].Cells["Apellido"].Value);
                string? dniSocio = Convert.ToString(dgtvTurnos.SelectedRows[0].Cells["DNI"].Value);
                string? idSocio = Convert.ToString(dgtvTurnos.SelectedRows[0].Cells["IDMiembro"].Value);
                string? correoSocio = Convert.ToString(dgtvTurnos.SelectedRows[0].Cells["Correo"].Value);
                string? fechaInscripcion = DateTime.Now.ToString("dd/MM/yyyy");

                bool esSocio = Convert.ToBoolean(dgtvTurnos.SelectedRows[0].Cells["EsSocio"].Value);

                FormCarnet comprobanteTurno = new FormCarnet(nombreSocio, apellidoSocio, dniSocio, idSocio, correoSocio, fechaInscripcion);
                comprobanteTurno.ShowDialog();
            }
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {
            turnoDB.obtenerTurnosDisponibles(dgtvTurnos);
        }

        
    }
}
