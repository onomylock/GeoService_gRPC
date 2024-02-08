using MediatR;
using Shared.GrpcClientLibrary;

namespace Core.Application.Tasks.Queries
{
    public class GetListQuery : IRequest<TaskDto>
    {
        public long Id { get; set; }
    }

    public class GetListQueryHandler : IRequestHandler<GetListQuery, TaskDto>
    {
        public Task<TaskDto> Handle(GetListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
