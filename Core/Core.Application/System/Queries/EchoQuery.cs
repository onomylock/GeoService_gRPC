using MediatR;

namespace Core.Application.System.Queries
{
    public class EchoQuery : IRequest<string>
    {
        public string Message { get; set; }
    }

    public class EchoQueryHandler : IRequestHandler<EchoQuery, string>
    {
        public Task<string> Handle(EchoQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
