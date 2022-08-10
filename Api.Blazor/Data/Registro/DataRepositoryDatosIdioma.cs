using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Data.Registro
{
    public class DataRepositoryDatosIdioma
    {
        public void PostDatosIdiomas(DatosIdioma item)
        {
            using (var context = new dbblazorContext())
            {
                context.DatosIdiomas.Add(item);
                context.SaveChanges();
            }
        }

        public List<DatosIdioma> GetDatosIdiomas(int IdDato)
        {
            using (var context = new dbblazorContext())
            {
                return context.DatosIdiomas.Where(a => a.IdDato == IdDato
                && a.Estado == "ACTIVO").ToList();
            }
        }

    }
}
