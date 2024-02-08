using Core.Application.Files.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Core.Application.Files.Queries
{
    public class FileListQuery : IRequest<FileListResponse>
    {
        public string Path { get; set; }
    }

    public class FileListQueryHandler : IRequestHandler<FileListQuery, FileListResponse>
    {
        public Task<FileListResponse> Handle(FileListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
