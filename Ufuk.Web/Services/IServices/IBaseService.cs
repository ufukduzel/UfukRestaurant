using Ufuk.Web.Models;

namespace Ufuk.Web.Services.IServices
{
    // 56th step.
    public interface IBaseService : IDisposable
    {
        // 57th step.
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
