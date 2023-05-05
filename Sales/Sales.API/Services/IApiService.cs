using Sales.Shared.Responses;
using Sales.Shared.Responses.Sales.Shared.Responses;

namespace Sales.API.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string servicePrefix, string controller);
    }
}
