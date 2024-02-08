using Core.Application.Files.Models;
using MediatR;
using Microsoft.Extensions.Logging;
using MimeKit;

namespace Core.Application.Files.Queries
{
    public class DownloadQuery : IRequest<DownloadResponse>
    {
        public string File { get; set; }
    }

    public class DownloadQueryHandler(ILogger<DownloadQuery> logger) : IRequestHandler<DownloadQuery, DownloadResponse>
    {
        private readonly ILogger<DownloadQuery> _logger = logger;

        public Task<DownloadResponse> Handle(DownloadQuery request, CancellationToken cancellationToken)
        {
            var result = new DownloadResponse();
            
            var mas = File.ReadAllBytes(request.File);
            var fileType = MimeTypes.GetMimeType(request.File);
            var fileName = Path.GetFileName(request.File);

            

            //result.file = new File(mas, fileType, fileName);

            throw new NotImplementedException();
        }
    }
}
