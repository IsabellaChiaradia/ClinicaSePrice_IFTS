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

        public E_Persona()
        {
        }

        public E_Persona(int id, string? nombre, string? apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

        public E_Persona(int id, string? nombre, string? apellido, string? nroDoc, string? email, DateTime fechaNac, string? telefono, string? domicilio)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NroDoc = nroDoc;
            Email = email;
            FechaNac = fechaNac;
            Telefono = telefono;
            Domicilio = domicilio;
        }

    }
}
