using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;
using Api.Blazor.Interfaces.Registro;
using Api.Blazor.Data.Registro;

namespace Api.Blazor.Services.Registro
{
    public class ServicesDatosPersonales : IDataRepositoryDatosPersonales
    {
        public DataRepositoryDatosPersonales data = new DataRepositoryDatosPersonales();
        
        public IEnumerable<DatosPersonale> GetDatosPersonales(int IdDato)
        {
            return data.GetDatosPersonales(IdDato);
        }

        public void PostDatosPersonales(DatosPersonale item)
        {
            data.PostDatosPersonales(item);
        }

    }
}
