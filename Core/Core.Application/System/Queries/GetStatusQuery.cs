using MediatR;
using Shared.GrpcClientLibrary;

namespace Core.Application.System.Queries
{
    public class GetStatusQuery : IRequest<SystemStatus>
    {
    }

    public class GetStatusQueryHandler : IRequestHandler<GetStatusQuery, SystemStatus>
    {
        public Task<SystemStatus> Handle(GetStatusQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
