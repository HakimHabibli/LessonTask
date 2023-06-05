using System.Net;

namespace ProductAPI.Utilities.ResponseMessages
{
    public class ResponseMessage
    {
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}
