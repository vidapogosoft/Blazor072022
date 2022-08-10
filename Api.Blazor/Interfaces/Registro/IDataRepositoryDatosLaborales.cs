using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Interfaces.Registro
{
   public interface IDataRepositoryDatosLaborales
    {
        void PostDatosLaboral(DatosLaboral item);
        IEnumerable<DatosLaboral> GetDatosLaboral(int IdDato);
    }
}
