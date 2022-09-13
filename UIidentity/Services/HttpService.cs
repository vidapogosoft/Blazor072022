using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UIidentity.Services
{
    public class HttpService: IHttpService
    {
        private readonly HttpClient httpClient;

        private JsonSerializerOptions defaultJsonSerializerOptions =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public HttpService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data)
        {
            try
            {
                var dataJson = JsonSerializer.Serialize(data);
                var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, stringContent);

                var responseDeserialized = await Deserialize<TResponse>(response, defaultJsonSerializerOptions);

                if (!response.IsSuccessStatusCode)
                {
                    return new HttpResponseWrapper<TResponse>(default, false, response);
                }

                return new HttpResponseWrapper<TResponse>(responseDeserialized, true, response);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

           
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage httpResponse, JsonSerializerOptions options)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, options);
        }

    }
}
