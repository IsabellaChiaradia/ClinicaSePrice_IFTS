using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    public class E_Cuota
    {
        public int IDCuota { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVenc { get; set; }
        public int IDMiembro { get; set; }
 
    }
}
