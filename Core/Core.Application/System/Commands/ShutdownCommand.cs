using Core.Common.Responses;
using MediatR;

namespace Core.Application.System.Commands
{
    public class ShutdownCommand : IRequest<BaseResponse>
    {
    }

    public class ShutdownCommandHandler : IRequestHandler<ShutdownCommand, BaseResponse>
    {
        public Task<BaseResponse> Handle(ShutdownCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
