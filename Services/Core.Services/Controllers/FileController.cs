using Core.Application.Commands.FileCommands;
using Core.Application.Files.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Core.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromBody] UploadCommand command) => Ok(await _mediator.Send(command));

        [HttpGet("download")]
        public async Task<IActionResult> Download([FromQuery] DownloadQuery query) => Ok(await _mediator.Send(query));

        [HttpGet("list")]
        public async Task<IActionResult> List([FromQuery] FileListQuery query) => Ok(await _mediator.Send(query));
    }
}
