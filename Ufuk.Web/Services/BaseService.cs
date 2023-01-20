using Newtonsoft.Json;
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

        public async Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            // 64th step.
            try
            {
                var client = httpClient.CreateClient("UfukAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear();
                // 65th step.
                if (apiRequest.Data != null)
                {
                    // Install package 'Newtonsoft.Json' (for JsonConvert)
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json");
                }

                // 66th step.
                HttpResponseMessage apiResponse = null;
                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;
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
