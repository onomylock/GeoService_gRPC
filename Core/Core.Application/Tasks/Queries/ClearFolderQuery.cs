using MediatR;

namespace Core.Application.Tasks.Queries
{
    public class ClearFolderQuery : IRequest<string>
    {
    }

    public class ClearFolderQueryHandler : IRequestHandler<ClearFolderQuery, string>
    {
        public Task<string> Handle(ClearFolderQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
