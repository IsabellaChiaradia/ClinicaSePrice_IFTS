﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Entidades
{
    internal class E_Usuario
    {
        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int IdRol { get; set; } 
        public string? Email { get; set; }
        public string? Contrasenia { get; set; }
        public Boolean isActivo { get; set; }
    }
}
