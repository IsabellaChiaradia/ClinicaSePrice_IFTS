using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    internal class E_Usuario
    {
        public int IDUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int IDRol { get; set; } 
        public string? Email { get; set; }
        public string? Contrasenia { get; set; }
        public Boolean EstaActivo { get; set; }
    }
}
