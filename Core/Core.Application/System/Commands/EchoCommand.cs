using MediatR;

namespace Core.Application.System.Commands
{
    public class EchoCommand : IRequest<string>
    {
        public string Message { get; set; }
    }

    public class EchoCommandHandler : IRequestHandler<EchoCommand, string>
    {
        public Task<string> Handle(EchoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
