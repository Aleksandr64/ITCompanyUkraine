using System.Net;
using ITCompany.Domain;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace ITCompany.Web.Handler;

public class GlobalExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is ApiException apiException) 
        {
            
            var errorResponse = new ErrorResponse
            {
                StatusCode = apiException.Status,
                Name = apiException.Message,
                Errors = apiException.Data
            };
            httpContext.Response.StatusCode = errorResponse.StatusCode;
            await httpContext
                .Response
                .WriteAsJsonAsync(errorResponse, cancellationToken);
        }
        else
        {
            var errorResponse = new ProblemDetails()
            {
                Status = (int)HttpStatusCode.InternalServerError,
                Type = exception.GetType().Name,
                Title = "An unhandled error occurred",
                Detail = exception.Message,
            };
            await httpContext
                .Response
                .WriteAsJsonAsync(errorResponse, cancellationToken);
        }
        return true;
    }
}