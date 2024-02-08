using Core.Common.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;

namespace Core.Application.Files.Commands
{
    public class UploadCommand : IRequest<BaseResponse>
    {
        public string Path { get; set; }
        public List<IFormFile> Files { get; set; }
    }

    public class UploadCommandHandler(ILogger<UploadCommand> logger) : IRequestHandler<UploadCommand, BaseResponse>
    {
        private readonly ILogger<UploadCommand> _logger = logger;

        public async Task<BaseResponse> Handle(UploadCommand request, CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Information, "upload files request: path = " + request.Path);

            if(!Directory.Exists(request.Path)) 
            {
                Directory.CreateDirectory(request.Path);
            }            

            foreach(var file in request.Files) 
            {                
                using (var stream = new FileStream(Path.Combine(request.Path, file.FileName), FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return await Task.FromResult(new BaseResponse() { IsSuccess = true, Message = "Done"});
        }
    }
}
