using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    public class E_Especialidad
    {
        public int IdEspecialidad { get; set; }
        public string? Tipo { get; set; }

        public E_Especialidad()
        {

        }

        public E_Especialidad(int idEspecialidad, string? tipo)
        {
            IdEspecialidad = idEspecialidad;
            Tipo = tipo;
        }

    }
}
