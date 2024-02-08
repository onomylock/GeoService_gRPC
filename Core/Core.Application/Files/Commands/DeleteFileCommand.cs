using Core.Common.Responses;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Core.Application.Files.Commands
{
    public class DeleteFileCommand : IRequest<BaseResponse>
    {
        public string Path { get; set; }
    }

    public class DeleteFileCommandHandler(ILogger<DeleteFileCommand> logger) : IRequestHandler<DeleteFileCommand, BaseResponse>
    {
        private readonly ILogger<DeleteFileCommand> _logger = logger;

        public Task<BaseResponse> Handle(DeleteFileCommand request, CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Information, "start deleting file " + request.Path);

            File.Delete(request.Path);

            return Task.FromResult(new BaseResponse()
            {
                IsSuccess = true,
                Message = "Done"
            });
        }
    }
}
