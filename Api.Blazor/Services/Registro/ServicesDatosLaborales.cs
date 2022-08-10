using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Model.Blazor.Models.Database;
using Api.Blazor.Interfaces.Registro;
using Api.Blazor.Data.Registro;

namespace Api.Blazor.Services.Registro
{
    public class ServicesDatosLaborales : IDataRepositoryDatosLaborales
    {
        public DataRepositoryDatosLaboral data = new DataRepositoryDatosLaboral();

        public IEnumerable<DatosLaboral> GetDatosLaboral(int IdDato)
        {
            return data.GetDatosLaboral(IdDato);
        }

        public void PostDatosLaboral(DatosLaboral item)
        {
            data.PostDatosLaboral(item);
        }
    }
}
