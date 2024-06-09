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

        public E_Medico()
        {
        }

        public E_Medico(int id, string? nombre, string? apellido) : base(id, nombre, apellido)
        {
        }

        public E_Medico(int id, string? nombre, string? apellido, string? nroDoc, string? email, DateTime fechaNac, string? telefono, string? domicilio, int duracionTurno, E_Especialidad especialidad) : base(id, nombre, apellido, nroDoc, email, fechaNac, telefono, domicilio)
        {
            DuracionTurno = duracionTurno;
            Especialidad = especialidad;
        }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

    }
}
