using MediatR;

namespace Core.Application.Tasks.Queries
{
    public class GetAwakeStatusQuery : IRequest<string>
    {
    }

    public class GetAwakeStatusQueryHandler : IRequestHandler<GetAwakeStatusQuery, string>
    {
        public Task<string> Handle(GetAwakeStatusQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
