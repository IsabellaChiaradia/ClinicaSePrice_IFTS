using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    public class E_Actividad
    {
        public int IDMiembro { get; set; }
        public string? Nombre { get; set; }
        public int CupoMax { get; set; }
        public double Costo { get; set; }
    }
}
