using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Interfaces.Registro
{
    interface IDataRepositoryDatosIdiomas
    {
        void PostDatosIdiomas(DatosIdioma item);
        IEnumerable<DatosIdioma> GetDatosIdiomas(int IdDato);

    }
}
