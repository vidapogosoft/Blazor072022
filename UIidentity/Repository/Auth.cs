using System.Threading.Tasks;
using System;
using UIidentity.Model;
using UIidentity.Services;

namespace UIidentity.Repository
{
    public class Auth : IAuth
    {
        private readonly IHttpService httpService;

        public Auth(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<Token> Login(AuthInfo auth)
        {
            try
            {
                var httpResponse = await httpService.Post<AuthInfo, Token>("http://localhost:25636/api/Token/authenticate", auth);

                if (!httpResponse.Success)
                {
                    throw new ApplicationException(await httpResponse.GetBody());
                }

                return httpResponse.Response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

         
        }

    }
}
