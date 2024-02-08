using Core.Common.Responses;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace Core.Common.Exeptions
{
    public class ExceptionLoggingHandler<TRequest, TResponse, TException>
        (ILogger<ExceptionLoggingHandler<TRequest, TResponse, TException>> logger) 
        : IRequestExceptionHandler<TRequest, TResponse, TException>
         where TRequest : IRequest<TResponse>
         where TResponse : BaseResponse, new()
         where TException : Exception
    {
        private readonly ILogger<ExceptionLoggingHandler<TRequest, TResponse, TException>> _logger = logger;

        public Task Handle(TRequest request, TException exception, RequestExceptionHandlerState<TResponse> state, CancellationToken cancellationToken)
        {            
            _logger.LogError(exception, "Something went wrong while handling request of type {@requestType}", typeof(TRequest));

            var response = new TResponse
            {
                IsSuccess = true,
                Message = "A server error ocurred"
            };

            state.SetHandled(response);

            return Task.CompletedTask;
        }
    }
}
