using AutoMapper;
using Core.Application.System.Commands;
using Core.Application.System.Queries;
using Grpc.Core;
using MediatR;
using Shared.GrpcClientLibrary;

namespace Core.Services.GrpcServices
{
    public class SystemServiceImplementation(IMapper mapper, IMediator mediator) : SystemService.SystemServiceBase
    {
        private readonly IMediator _mediator = mediator;
        private readonly IMapper _mapper = mapper;

        public override async Task<EchoResponse> Echo(EchoRequest request, ServerCallContext context)
        {
            var echoQuery = _mapper.Map<EchoQuery>(request);
            var result = await _mediator.Send(echoQuery);

            return _mapper.Map<EchoResponse>(result);
        }

        public override async Task<GetSystemStatusResponse> GetSystemStatus(GetSystemStatusRequest request, ServerCallContext context)
        {
            var getSystemStatusQuery = _mapper.Map<GetStatusQuery>(request);
            var result = await _mediator.Send(getSystemStatusQuery);

            return _mapper.Map<GetSystemStatusResponse>(result);
        }

        public override async Task<ShutdownResponse> Shutdown(ShutdownRequest request, ServerCallContext context)
        {
            var shutDownCommand = _mapper.Map<ShutdownCommand>(request);
            var result = await _mediator.Send(shutDownCommand);

            return _mapper.Map<ShutdownResponse>(result);
        }

        public override async Task<VersionResponse> Version(VersionRequest request, ServerCallContext context)
        {
            var versionQuery = _mapper.Map<VersionQuery>(request);
            var result = await _mediator.Send(versionQuery);

            return _mapper.Map<VersionResponse>(result);
        }
    }
}
