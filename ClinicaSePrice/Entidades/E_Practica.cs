using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    public class E_Practica
    {
        public int IdPractica { get; set; }
        public string? Codigo { get; set; }
        public double Costo { get; set; }
        public string? Descripcion { get; set; }
        public E_Especialidad? Especialidad { get; set; }
 
    }
}
