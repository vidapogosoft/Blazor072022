using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;
using Api.Blazor.Interfaces.Registro;
using Api.Blazor.Data.Registro;

namespace Api.Blazor.Services.Registro
{
    public class ServicesDatosEducacion : IDataRepositoryDatosEducacion
    {
        public DataRepositoryDatosEducacion data = new DataRepositoryDatosEducacion();

        public IEnumerable<DatosEducacion> GetDatosEducacion(int IdDato)
        {
            return data.GetDatosEducacion(IdDato);
        }

        public void PostDatosEducacion(DatosEducacion item)
        {
            data.PostDatosEducacion(item);
        }
    }
}
