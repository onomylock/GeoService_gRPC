using MediatR;

namespace Core.Application.Tasks.Queries
{
    public class RunningTaskCountQuery : IRequest<string>
    {
    }

    public class RunningTaskCountQueryHandler : IRequestHandler<RunningTaskCountQuery, string>
    {
        public Task<string> Handle(RunningTaskCountQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
