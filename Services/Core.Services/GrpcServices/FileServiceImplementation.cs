using AutoMapper;
using Core.Application.Commands.FileCommands;
using Core.Application.Files.Commands;
using Core.Application.Files.Queries;
using Grpc.Core;
using MediatR;
using Shared.GrpcClientLibrary;

namespace Core.Services.GrpcServices
{
    public class FileServiceImplementation(IMapper mapper, IMediator mediator) : FileService.FileServiceBase
    {
        private readonly IMediator _mediator = mediator;
        private readonly IMapper _mapper = mapper;

        public override async Task<ArchiveDirectoryResponse> ArchiveDirectory(ArchiveDirectoryRequest request, ServerCallContext context)
        {
            var archiveDirectoryCommand = _mapper.Map<ArchiveDirectoryCommand>(request);
            var result = await _mediator.Send(archiveDirectoryCommand);

            return _mapper.Map<ArchiveDirectoryResponse>(result);
        }

        public override async Task<DeleteFileRespose> DeleteFile(DeleteFileRequest request, ServerCallContext context)
        {
            var deleteFileCommand = _mapper.Map<DeleteFileCommand>(request);
            var result = await _mediator.Send(deleteFileCommand);

            return _mapper.Map<DeleteFileRespose>(result);
        }

        public override async Task<GetFileContentRespose> GetFileContent(GetFileContentRequest request, ServerCallContext context)
        {
            var fileContentQuery = _mapper.Map<FileContentQuery>(request);
            var result = await _mediator.Send(fileContentQuery);

            return _mapper.Map<GetFileContentRespose>(result);
        }
        
    }
}
