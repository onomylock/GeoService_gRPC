using MediatR;
using Microsoft.AspNetCore.Http;
using Shared.GrpcClientLibrary;

namespace Core.Application.Tasks.Commands
{
    public class AddTaskCommand : IRequest<TaskDto>
    {
        public TaskDto Description { get; set; }
        public IFormFile[] Dependencies { get; set; }
        public string[] LocalPath { get; set; }
    }

    public class AddTaskCommandHandler : IRequestHandler<AddTaskCommand, TaskDto>
    {
        public Task<TaskDto> Handle(AddTaskCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
