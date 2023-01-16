using static Ufuk.Web.SD;

namespace Ufuk.Web.Models
{
    //54th step.
    public class ApiRequest
    {
        //55th step.
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
