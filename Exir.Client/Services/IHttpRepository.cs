namespace Exir.Client.Services
{
    public interface IHttpRepository<T> where T : class
    {
        Task<List<T>> GetAll(string url);
        Task<T> Get(string url, int id);
        Task Post(string url, T data);
    }
}
