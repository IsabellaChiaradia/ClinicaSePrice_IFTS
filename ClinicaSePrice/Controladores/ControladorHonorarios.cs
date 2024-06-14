using ClinicaSePrice.Datos;
using ClinicaSePrice.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaSePrice.Controladores
{
    internal class ControladorHonorarios
    {
        private Turno datosTurno;
        private Medico datosMedico;

        public ControladorHonorarios()
        {
            this.datosTurno = new Turno();
            this.datosMedico = new Medico();
        }

        public void CargarHonorariosMedico(DataGridView dtgv, string dni, string tipoLiquidacion)
        {
            var medico = datosMedico.GetMedicoPorDNI(dni);

            if (medico != null)
            {
                List<E_Turno> turnos = new List<E_Turno>();
                DateTime fechaDesde;
                DateTime fechaHasta;

                switch (tipoLiquidacion)
                {
                    case "Diaria":
                        fechaDesde = DateTime.Now.Date;
                        fechaHasta = fechaDesde;
                        break;
                    case "Semanal":
                        fechaDesde = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
                        fechaHasta = fechaDesde.AddDays(6);
                        break;
                    case "Mensual":
                        fechaDesde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        fechaHasta = fechaDesde.AddMonths(1).AddDays(-1);
                        break;
                    default:
                        MessageBox.Show("Seleccione un tipo de liquidación válido");
                        return;
                }

                decimal totalHonorarios = 0;

                for (DateTime fecha = fechaDesde; fecha <= fechaHasta; fecha = fecha.AddDays(1))
                {
                    var honorariosDia = datosTurno.ObtenerHonorariosMedico(fecha.ToString("yyyy-MM-dd"), medico.Id);
                    totalHonorarios += (decimal)honorariosDia;

                    turnos.Add(new E_Turno
                    {
                        FechaAtencion = fecha,
                        CostoFinal = (double)honorariosDia
                    });
                }

                dtgv.DataSource = turnos.Select(t => new
                {
                    Fecha = t.FechaAtencion,
                    Honorarios = t.CostoFinal
                }).ToList();
                MessageBox.Show($"Total de honorarios: {totalHonorarios:C}");
            }
            else
            {
                MessageBox.Show("No se encontró el médico con el DNI proporcionado.");
            }
        }
    }
}
