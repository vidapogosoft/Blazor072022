using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Data.Registro
{
    public class DataRepositoryDatosLaboral
    {
        public void PostDatosLaboral(DatosLaboral item)
        {
            using (var context = new dbblazorContext())
            {
                context.DatosLaborals.Add(item);
                context.SaveChanges();
            }
        }

        public List<DatosLaboral> GetDatosLaboral(int IdDato)
        {
            using (var context = new dbblazorContext())
            {
                return context.DatosLaborals.Where(a => a.IdDato == IdDato
                && a.Estado == "ACTIVO").ToList();
            }
        }

    }
}
