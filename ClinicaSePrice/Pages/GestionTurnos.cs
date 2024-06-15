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
        private E_Turno? turnoSeleccionado;

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

            this.pacienteSeleccionado = pacienteDB.BuscarPacientePorDNI(dni);

            if (this.pacienteSeleccionado == null)
            {
                MessageBox.Show("No se encontró el paciente con el DNI ingresado. Regístrelo en Registrar Paciente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDniGestion.Text = "DNI";
            }
            else
            {
                MessageBox.Show($"Paciente encontrado: {this.pacienteSeleccionado.Nombre} {this.pacienteSeleccionado.Apellido}", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (pacienteSeleccionado == null || practicaSeleccionada == null || turnoSeleccionado == null)
            {
                MessageBox.Show("Para registrar un turno debe seleccionar un paciente, una practica y un turno disponible", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (turnoSeleccionado.IdTurno == -1)
            {
                MessageBox.Show("El turno seleccionado no está disponible", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var respuesta = this.turnoDB.RegistrarTurno(pacienteSeleccionado.Id,
                turnoSeleccionado.Medico.Id,
                practicaSeleccionada.IdPractica,
                turnoSeleccionado.FechaAtencion,
                turnoSeleccionado.HoraInicio,
                turnoSeleccionado.HoraFin);
            if (respuesta > 0)
            {
                this.buscarPosiblesTurnos();
            }
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {
            this.buscarPosiblesTurnos();
        }

        private void buscarPosiblesTurnos()
        {
            this.turnoSeleccionado = null;
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

        private void dgtvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = this.dgtvTurnos.Rows[e.RowIndex];
                DataRow? filaOriginal = filaSeleccionada.Tag as DataRow;


                if (filaOriginal != null)
                {
                    this.turnoSeleccionado = new E_Turno();
                    Boolean isTurnoDisponible = filaOriginal["idTurno"] == DBNull.Value;
                    if (isTurnoDisponible)
                    {
                        // Obtener los valores de la fila original
                        this.turnoSeleccionado.FechaAtencion = Convert.ToDateTime(filaOriginal["fecha"]);
                        this.turnoSeleccionado.HoraInicio = (TimeSpan)filaOriginal["hora_inicio"];
                        this.turnoSeleccionado.HoraFin = (TimeSpan)filaOriginal["hora_fin"];
                        this.turnoSeleccionado.Medico = new E_Medico(Convert.ToInt32(filaOriginal["id_medico"]));
                    }
                    else
                    {
                        this.turnoSeleccionado.IdTurno = -1; // esto significa que el turno seleccionado está reservado
                    }


                }
            }
        }



    }
}
