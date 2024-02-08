using MediatR;

namespace Core.Application.Tasks.Commands
{
    public class StopTaskCommand : IRequest<string>
    {
        public string Id { get; set; }
    }

    public class StopTaskCommandHandler : IRequestHandler<StopTaskCommand, string>
    {
        public Task<string> Handle(StopTaskCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
