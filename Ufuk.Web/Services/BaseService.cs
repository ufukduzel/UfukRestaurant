using System.Text;
using System.Text.Json.Serialization;
using Ufuk.Web.Models;
using Ufuk.Web.Services.IServices;

namespace Ufuk.Web.Services
{
    // 58th step.
    public class BaseService : IBaseService
    {
        // 59th step.
        public ResponseDto responseModel { get; set; } // 61st step.
        public IHttpClientFactory httpClient { get; set; } // 62nd step.

        // 63rd step.
        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new ResponseDto();
            this.httpClient = httpClient;
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            // 64th step.
            try
            {
                var client = httpClient.CreateClient("UfukAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public void Dispose()
        {
            // 60th step.
            GC.SuppressFinalize(true);
        }
    }
}
