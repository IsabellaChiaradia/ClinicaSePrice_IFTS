using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    internal class E_Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NroDoc { get; set; }
        public string? Email { get; set; }
        public DateTime FechaNac { get; set; }
        public string? Telefono { get; set; }
        public string? Domicilio { get; set; }
    }
}
