using Core.Application.Files.Models;
using MediatR;

namespace Core.Application.Files.Queries
{
    public class FileContentQuery : IRequest<FileContentResponse>
    {
        public string FileName { get; set; }
    }

    public class FileContentQueryHeandler : IRequestHandler<FileContentQuery, FileContentResponse>
    {
        //private readonly ILogger<FileContentQuery> _logger = logger;

        public async Task<FileContentResponse> Handle(FileContentQuery request, CancellationToken cancellationToken)
        {
            var result = new FileContentResponse();
            result.Content = await File.ReadAllLinesAsync(request.FileName);
            result.IsSuccess = true;
            result.Message = "Done";

            return result;
        }
    }
}
