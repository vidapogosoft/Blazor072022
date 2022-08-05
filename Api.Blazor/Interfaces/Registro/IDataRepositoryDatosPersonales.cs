using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Interfaces.Registro
{
    public interface IDataRepositoryDatosPersonales
    {
        void PostDatosPersonales(DatosPersonale item);
        IEnumerable<DatosPersonale> GetDatosPersonales(int IdDato);
    }
}
