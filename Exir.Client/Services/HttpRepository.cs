
using System.Net.Http.Json;

namespace Exir.Client.Services
{
    public class HttpRepository<T> : IHttpRepository<T> where T : class
    {
        private readonly HttpClient httpClient;

        public HttpRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<T> Get(string url, int id)
        {
            return await httpClient.GetFromJsonAsync<T>($"{url}/{id}");
        }

        public async Task<List<T>> GetAll(string url)
        {
            return await httpClient.GetFromJsonAsync<List<T>>(url);
        }

        public async Task Post(string url, T data)
        {
            await httpClient.PostAsJsonAsync(url, data);
        }
    }
}
