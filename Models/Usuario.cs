﻿using Microsoft.AspNetCore.Identity;

namespace backend_integrador.Models
{
    public class Usuario : IdentityUser
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
    }
}
