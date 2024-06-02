using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    internal class E_Medico : E_Persona
    {
        public int DuracionTurno { get; set; }
        public E_Especialidad? Especialidad { get; set; }

    }
}
