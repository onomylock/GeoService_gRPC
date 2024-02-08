using Core.Common.Responses;
using MediatR;
using Microsoft.Extensions.Logging;
using System.IO.Compression;

namespace Core.Application.Files.Commands
{
    public class ArchiveDirectoryCommand : IRequest<BaseResponse>
    {
        public string Path { get; set; }
    }

    public class ArchiveDirectoryCommandHandler(ILogger<ArchiveDirectoryCommand> logger) : IRequestHandler<ArchiveDirectoryCommand, BaseResponse>
    {
        private readonly ILogger<ArchiveDirectoryCommand> _logger = logger;

        public Task<BaseResponse> Handle(ArchiveDirectoryCommand request, CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Information, "start archiving a folder " + request.Path);
            ZipFile.CreateFromDirectory(request.Path, request.Path + ".zip");

            return Task.FromResult(new BaseResponse());
        }
    }
}
