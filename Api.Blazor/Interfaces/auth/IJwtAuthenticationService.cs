using Model.Blazor.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Blazor.Models.DTO;

namespace Api.Blazor.Interfaces.auth
{
    public interface IJwtAuthenticationService
    {
        Token Authenticate(string username, string password);
         void Registro(RegistroInicial item);
    }
}
