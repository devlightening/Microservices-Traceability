using Microsoft.Extensions.Primitives;

namespace AspNetCoreApp.Middlewares
{
    public class CorrelationMiddleware(RequestDelegate next)
    {
        const string correlationIdHeaderKey = "X-Correlation-ID";

         public async Task Invoke(HttpContext context , ILogger<CorrelationMiddleware> logger )
        {
            string correlationId = Guid.NewGuid().ToString();

            if (context.Request.Headers.TryGetValue(correlationIdHeaderKey, out StringValues _correlationId))
                            correlationId = _correlationId;
            
            else 
                context.Request.Headers.Add(correlationIdHeaderKey, correlationId);

            NLog.MappedDiagnosticsContext.Set("CorrelationId", correlationId);

            logger.LogDebug("Asp.NET Core Application CorrelationID Log Example");

            context.Response.OnStarting(() =>
            {
                if (context.Response.Headers.TryGetValue(correlationIdHeaderKey, out _))
                    context.Response.Headers.Add(correlationIdHeaderKey, correlationId);

                return Task.CompletedTask;

            });

            context.Items["CorrelationId"] = correlationId;
            await next(context);

        }

    }
}
