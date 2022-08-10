using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Model.Blazor.Models.Database;
using Api.Blazor.Interfaces.Registro;
using Api.Blazor.Data.Registro;

namespace Api.Blazor.Services.Registro
{
    public class ServicesDatosIdiomas : IDataRepositoryDatosIdiomas
    {
        public DataRepositoryDatosIdioma data = new DataRepositoryDatosIdioma();

        public IEnumerable<DatosIdioma> GetDatosIdiomas(int IdDato)
        {
            return data.GetDatosIdiomas(IdDato);
        }

        public void PostDatosIdiomas(DatosIdioma item)
        {
            data.PostDatosIdiomas(item);
        }
    }
}
