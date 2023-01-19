using Ufuk.Web.Models;
using Ufuk.Web.Services.IServices;

namespace Ufuk.Web.Services
{
    // 58th step.
    public class BaseService : IBaseService
    {
        // 59th step.
        public ResponseDto responseModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // 60th step.
            GC.SuppressFinalize(true);
        }
    }
}
