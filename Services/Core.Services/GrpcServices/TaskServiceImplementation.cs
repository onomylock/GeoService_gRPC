using AutoMapper;
using Grpc.Core;
using MediatR;
using Shared.GrpcClientLibrary;
using Core.Application.Tasks.Commands;
using Core.Application.Tasks.Queries;

namespace Core.Services.GrpcServices
{
    public class TaskServiceImplementation(IMapper mapper, IMediator mediator) : TaskService.TaskServiceBase
    {
        private readonly IMediator _mediator = mediator;
        private readonly IMapper _mapper = mapper;

        public override Task<AwakeStatusResponse> AwakeStatus(AwakeStatusRequest request, ServerCallContext context)
        {
            return base.AwakeStatus(request, context);
        }

        public override async Task<ClearFolderResponse> ClearFolder(ClearFolderRequest request, ServerCallContext context)
        {
            var clearFolderQuery = _mapper.Map<ClearFolderQuery>(request);
            var result = await _mediator.Send(clearFolderQuery);


            return _mapper.Map<ClearFolderResponse>(result);
        }

        public override async Task<GetListTaskResponse> GetListTask(GetListTaskRequest request, ServerCallContext context)
        {
            var listTaskQuery = _mapper.Map<GetListQuery>(request);
            var result = await _mediator.Send(listTaskQuery);

            return _mapper.Map<GetListTaskResponse>(result);
        }

        public override async Task<RunningTusksCountResponse> RunningTusksCount(RunningTusksCountRequest request, ServerCallContext context)
        {
            var runningTaskCountCommand = _mapper.Map<RunningTaskCountQuery>(request);
            var result = await _mediator.Send(runningTaskCountCommand);

            return _mapper.Map<RunningTusksCountResponse>(result);
        }

        public override async Task<StopTaskResponse> StopTask(StopTaskRequest request, ServerCallContext context)
        {
            var stopTaskCommand = _mapper.Map<StopTaskCommand>(request);
            var result = await _mediator.Send(stopTaskCommand);

            return _mapper.Map<StopTaskResponse>(result);
        }
    }
}
