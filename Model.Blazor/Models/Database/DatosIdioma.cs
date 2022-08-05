using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Blazor.Models.Database
{
    public partial class DatosIdioma
    {
        public int IdDatoIdioma { get; set; }
        public int IdDato { get; set; }
        public int? IdIdioma { get; set; }
        public int? IdNivelEscrito { get; set; }
        public int? IdNivelHablado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Estado { get; set; }
    }
}
