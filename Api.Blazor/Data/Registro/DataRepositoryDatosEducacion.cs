using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Data.Registro
{
    public class DataRepositoryDatosEducacion
    {
        public void PostDatosEducacion(DatosEducacion item)
        {
            using (var context = new dbblazorContext())
            {
                context.DatosEducacions.Add(item);
                context.SaveChanges();
            }
        }

        public List<DatosEducacion> GetDatosEducacion(int IdDato)
        {
            using (var context = new dbblazorContext())
            {
                return context.DatosEducacions.Where(a => a.IdDato == IdDato
                && a.Estado == "ACTIVO").ToList();
            }
        }

    }
}
