namespace Ufuk.Services.ProductAPI.Models.Dto
{
    //14th step.
    public class ResponseDto
    {
        //15th step.
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessage { get; set; }
    }
}
