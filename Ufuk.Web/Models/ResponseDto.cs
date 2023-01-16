namespace Ufuk.Web.Models
{
    //51st step.
    public class ResponseDto
    {
        //15th step.
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessage { get; set; }
    }
}
