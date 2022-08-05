using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Blazor.Models.Database
{
    public partial class DatosContacto
    {
        public int IdDatoContacto { get; set; }
        public int IdDato { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string EmailSecundario { get; set; }
        public int? IdPais { get; set; }
        public string ProvinciaEstado { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Facebook { get; set; }
        public string Twiter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Estado { get; set; }
    }
}
