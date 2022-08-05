using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Data.Registro
{
    public class DataRepositoryDatosPersonales
    {
        public void PostDatosPersonales(DatosPersonale item)
        {
            using (var context = new dbblazorContext())
            {
                context.DatosPersonales.Add(item);
                context.SaveChanges();
            }
        }

        public List<DatosPersonale> GetDatosPersonales(int IdDato)
        {
            using (var context = new dbblazorContext())
            {
                return context.DatosPersonales.Where(a => a.IdDato == IdDato
                && a.Estado == "ACTIVO").ToList();
            }
        }

    }
}
