using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Blazor.Models.Database
{
    public partial class DatosLaboral
    {
        public int IdDatoLaboral { get; set; }
        public int IdDato { get; set; }
        public string Empresa { get; set; }
        public int? IdActividadEmpresa { get; set; }
        public string Puesto { get; set; }
        public int? IdNivelExperiencia { get; set; }
        public int? IodAreaDelPuesto { get; set; }
        public int? IdPais { get; set; }
        public int? MesInicio { get; set; }
        public int? AnioInicio { get; set; }
        public int? MesFin { get; set; }
        public int? AnioFin { get; set; }
        public bool? Presente { get; set; }
        public bool? ExperienciaEnVentas { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Estado { get; set; }
    }
}
