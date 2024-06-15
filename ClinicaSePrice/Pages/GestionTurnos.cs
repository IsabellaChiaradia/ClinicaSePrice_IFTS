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
        private FormComprobanteTurno? comprobanteTurno;
        private Turno turnoDB;
        private Especialidad especialidadDB;
        private Medico medicoDB;
        private Practica practicaDB;
        private Paciente pacienteDB;
        private E_Especialidad? especialidadSeleccionada;
        private E_Medico? medicoSeleccionado;
        private E_Paciente? pacienteSeleccionado;
        private E_Practica? practicaSeleccionada;

        public GestionTurnos()
        {
            InitializeComponent();
            this.turnoDB = new Turno();
            this.especialidadDB = new Especialidad();
            this.medicoDB = new Medico();
            this.practicaDB = new Practica();
            this.pacienteDB = new Paciente();
        }

        private void GestionTurnos_Load(object sender, EventArgs e)
        {
            cargarEspecialidades();
            cargarMedicosXEspecialidad(-1);
            cargarPracticasXEspecialidad(-1);
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
            if (cboEspecialidad.SelectedIndex > 0)
            {
                this.especialidadSeleccionada = (E_Especialidad)cboEspecialidad.SelectedItem;
                cargarMedicosXEspecialidad(this.especialidadSeleccionada.IdEspecialidad);
                cargarPracticasXEspecialidad(this.especialidadSeleccionada.IdEspecialidad);
            }
            else
            {
                this.especialidadSeleccionada = null;
                cargarMedicosXEspecialidad(-1); // reiniciamos el combo de medicos
                cargarPracticasXEspecialidad(-1); // reiniciamos el combo de practicas
            }
        }

        private void cargarMedicosXEspecialidad(int idEspecialidad)
        {
            var medicos = new List<E_Medico>();

            medicos.Add(new E_Medico(0, "Seleccionar", "Medico"));

            if (idEspecialidad > 0)
            {
                medicos.AddRange(this.medicoDB.getMedicosXEspecialidad(idEspecialidad));
            }

            if (medicos.Count > 1)
            {
                cboMedico.Enabled = true;
            }
            else
            {
                cboMedico.Enabled = false;
            }

            cboMedico.DisplayMember = "NombreCompleto";
            cboMedico.ValueMember = "Id";
            cboMedico.DataSource = medicos;

            cboMedico.SelectedIndex = 0;

        }

        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedico.SelectedIndex > 0)
            {
                this.medicoSeleccionado = (E_Medico)cboMedico.SelectedItem;
            }
            else
            {
                this.medicoSeleccionado = null;
            }
        }

        private void cargarPracticasXEspecialidad(int idEspecialidad)
        {
            var practicas = new List<E_Practica>();

            practicas.Add(new E_Practica(0, "Seleccionar Practica"));

            if (idEspecialidad > 0)
            {
                practicas.AddRange(this.practicaDB.getPracticasXEspecialidad(idEspecialidad));
            }

            if (practicas.Count > 1)
            {
                cboPractica.Enabled = true;
            }
            else
            {
                cboPractica.Enabled = false;
            }

            cboPractica.DisplayMember = "Descripcion";
            cboPractica.ValueMember = "IdPractica";
            cboPractica.DataSource = practicas;

            cboPractica.SelectedIndex = 0;

        }

        private void cboPractica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPractica.SelectedIndex > 0)
            {
                this.practicaSeleccionada = (E_Practica)cboPractica.SelectedItem;
            }
            else
            {
                this.practicaSeleccionada = null;
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
            string dni = txtDniGestion.Text;

            if (dni == "DNI" || string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            E_Paciente paciente = pacienteDB.BuscarPacientePorDNI(dni);

            if (paciente == null)
            {
                MessageBox.Show("No se encontró el paciente con el DNI ingresado. Regístrelo en Registrar Paciente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDniGestion.Text = "DNI";
            }
            else
            {                
                MessageBox.Show($"Paciente encontrado: {paciente.Nombre} {paciente.Apellido}", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (dgtvTurnos.SelectedRows.Count > 0 && Convert.ToBoolean(dgtvTurnos.SelectedRows[0].Cells["Disponible"].Value))
            {
                try
                {
                    int idPaciente = Convert.ToInt32(dgtvTurnos.SelectedRows[0].Cells["IDPaciente"].Value);
                    int idPractica = Convert.ToInt32(dgtvTurnos.SelectedRows[0].Cells["IDPractica"].Value);
                    DateTime fechaTurno = Convert.ToDateTime(dgtvTurnos.SelectedRows[0].Cells["Fecha Atencion"].Value);
                    DateTime horaInicio = Convert.ToDateTime(dgtvTurnos.SelectedRows[0].Cells["Hora de Inicio"].Value);
                    DateTime horaFin = Convert.ToDateTime(dgtvTurnos.SelectedRows[0].Cells["Hora Fin"].Value);

                    //int idTurno = turnoDB.RegistrarTurno(idPaciente, idPractica, fechaTurno, horaInicio, horaFin);

                    dgtvTurnos.SelectedRows[0].Cells["Disponible"].Value = false;

                    //MessageBox.Show($"Turno registrado correctamente. ID de turno: {idTurno}", "Información",
                                   // MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el turno: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede registrar el turno seleccionado. Asegúrese de que esté disponible.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {
            var fechaActual = DateTime.Now.Date;
            var fechaDesde = dtpFechaDesde.Value.Date;
            var fechaHasta = dtpFechaHasta.Value.Date;
            var idMedico = this.medicoSeleccionado?.Id;
            var idEspecialidad = this.especialidadSeleccionada?.IdEspecialidad;

            if (fechaDesde < fechaActual)
            {
                MessageBox.Show("La fecha desde no puede ser menor al dia de hoy",
                                "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha hasta debe ser mayor o igual a la fecha desde",
                                "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (idMedico != null && idMedico > 0)
            {
                turnoDB.obtenerTurnosDisponiblesXMedico(dgtvTurnos, fechaDesde, fechaHasta, (int)idMedico);
            }
            else if (idEspecialidad != null && idEspecialidad > 0)
            {
                turnoDB.obtenerTurnosDisponiblesXEspecialidad(dgtvTurnos, fechaDesde, fechaHasta, (int)idEspecialidad);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una especialidad y/o un médico para realizar la consulta",
                                "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


    }
}
