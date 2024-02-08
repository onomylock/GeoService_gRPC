using Core.Common.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Core.Application.Files.Models
{
    public class DownloadResponse : BaseResponse
    {
        public FileResult file { get; set; }
        public string Path { get; set; }
    }
}
