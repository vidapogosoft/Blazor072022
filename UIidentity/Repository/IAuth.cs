using System.Threading.Tasks;
using UIidentity.Model;

namespace UIidentity.Repository
{
    public interface IAuth
    {
        Task<Token> Login(AuthInfo auth);
    }
}
