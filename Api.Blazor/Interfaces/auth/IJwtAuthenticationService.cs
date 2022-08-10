using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Blazor.Interfaces.auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string username, string password);
    }
}
