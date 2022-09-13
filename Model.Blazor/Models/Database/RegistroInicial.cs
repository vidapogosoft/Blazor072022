using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Blazor.Models.Database
{
    public partial class RegistroInicial
    {
        public int IdRegistro { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Estado { get; set; }
    }
}
