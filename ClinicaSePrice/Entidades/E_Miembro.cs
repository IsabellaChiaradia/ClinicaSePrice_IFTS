using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    public class E_Miembro
    {
        public int IDMiembro { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? DNI { get; set; }
        public Boolean EsSocio { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? FechaNac { get; set; }
        public Boolean AptoMedico { get; set; }
        
    }
}
