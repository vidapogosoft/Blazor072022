using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Blazor.Models.Database
{
    public partial class DatosPersonale
    {
        public int IdDato { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresCompletos { get; set; }
        public string Identificacion { get; set; }
        public string Email { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string FechaNacimientoConsulta { get; set; }
        public int? IdGenero { get; set; }
        public int? IdPais { get; set; }
        public int? IdEstadoCivil { get; set; }
        public bool? LicenciaConducir { get; set; }
        public bool? MovilidadPropia { get; set; }
        public bool? Discapacidad { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Estado { get; set; }
    }
}
