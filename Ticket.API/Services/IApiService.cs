using Ticket.Shared.Responses;

namespace Ticket.API.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string servicePrefix, string controller);
    }
}
