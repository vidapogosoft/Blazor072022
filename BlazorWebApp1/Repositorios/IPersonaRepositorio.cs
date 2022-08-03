using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebApp1.Repositorios
{
    public interface IPersonaRepositorio
    {
        Task<HttpResponseWrapper<T>> GetRegistrados<T>(string url);
    }
}
