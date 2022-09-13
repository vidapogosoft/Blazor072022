using System.Threading.Tasks;

namespace UIidentity.Services
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data);
    }
}
