using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;
using Api.Blazor.Interfaces.Registro;
using Api.Blazor.Data.Registro;

namespace Api.Blazor.Services.Registro
{
    public class ServicesDatosContacto : IDataRepositoryDatosContacto
    {
        public DataRepositoryDatosContacto data = new DataRepositoryDatosContacto();

        public IEnumerable<DatosContacto> GetDatosContacto(int IdDato)
        {
            return data.GetDatosContacto(IdDato);
        }

        public void PostDatosContacto(DatosContacto item)
        {
            data.PostDatosContacto(item);
        }

    }
}
