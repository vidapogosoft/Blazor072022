using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Model.Blazor.Models.Database;

namespace Api.Blazor.Data.Registro
{
    public class DataRepositoryDatosContacto
    {

        public void Registro(RegistroInicial item)
        {
            using (var context = new dbblazorContext())
            {
                context.RegistroInicials.Add(item);
                context.SaveChanges();
            }
        }

        public void PostDatosContacto(DatosContacto item)
        {
            using (var context = new dbblazorContext())
            {
                context.DatosContactos.Add(item);
                context.SaveChanges();
            }
        }

        public List<DatosContacto> GetDatosContacto(int IdDato)
        {
            using (var context = new dbblazorContext())
            {
                return context.DatosContactos.Where(a => a.IdDato == IdDato
                && a.Estado == "ACTIVO").ToList();
            }
        }

    }
}
