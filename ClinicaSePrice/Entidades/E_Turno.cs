using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    internal class E_Turno
    {
        public int IdTurno { get; set; }
        public DateTime FechaAtencion { get; set; }
        public DateTime FechaBaja { get; set; }
        public Boolean Acreditado { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public double CostoFinal { get; set; }
        public E_Paciente? Paciente { get; set; }
        public E_Medico? Medico { get; set; }
        public E_Practica? Practica { get; set; }
    }
}
