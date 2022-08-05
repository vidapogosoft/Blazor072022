using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Blazor.Models.Database
{
    public partial class DatosEducacion
    {
        public int IdDatoEducacion { get; set; }
        public int IdDato { get; set; }
        public string TituloCarrera { get; set; }
        public string Institucion { get; set; }
        public int? IdTipoEstudio { get; set; }
        public int? IdEstadoEstudio { get; set; }
        public string AreaEstudio { get; set; }
        public int? IdPais { get; set; }
        public int? MesInicio { get; set; }
        public int? AnioInicio { get; set; }
        public int? MesFin { get; set; }
        public int? AnioFin { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Estado { get; set; }
    }
}
