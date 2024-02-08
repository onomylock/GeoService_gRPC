using Core.Common.Responses;

namespace Core.Application.Files.Models
{
    public class FileContentResponse : BaseResponse
    {
        public string[]? Content { get; set; }
    }
}
