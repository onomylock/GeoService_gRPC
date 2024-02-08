using MediatR;

namespace Core.Application.System.Queries
{
    public class VersionQuery : IRequest<string>
    {
    }

    public class VersionQueryHandler : IRequestHandler<VersionQuery, string>
    {
        public Task<string> Handle(VersionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
