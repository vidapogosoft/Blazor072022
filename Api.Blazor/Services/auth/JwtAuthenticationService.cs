using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Blazor.Interfaces.auth;

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Model.Blazor.Models.Database;
using Api.Blazor.Data.Registro;
using Api.Blazor.Models.DTO;


namespace Api.Blazor.Services.auth
{
    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        public DataRepositoryDatosContacto data = new DataRepositoryDatosContacto();

        private readonly string _key;

        public JwtAuthenticationService(string key)
        {

            _key = key;
        }


        public void Registro(RegistroInicial item)
        {
            data.Registro(item);
        }

        public Token Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(username)
            || username != "register" || password != "data.register")
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.ASCII.GetBytes(_key);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                   {
                        new Claim(ClaimTypes.Name, username)
                   }),

                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey),
                SecurityAlgorithms.HmacSha256Signature)

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            Token tk = new Token();
            tk.TokenValue = tokenHandler.WriteToken(token);

            return tk;

        }
    }
}
