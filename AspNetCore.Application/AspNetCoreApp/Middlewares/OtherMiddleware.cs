namespace AspNetCoreApp.Middlewares
{
    public class OtherMiddleware(RequestDelegate next)
    {
        public async Task Invoke(HttpContext context , ILogger<OtherMiddleware> logger)
        {
            var correlationId = context.Request.Headers["X-Correlation-ID"].FirstOrDefault();
            //YA DA 

            correlationId = context.Items["CorrelationId"].ToString();

            NLog.MappedDiagnosticsContext.Set("CorrelationId", correlationId);
            logger.LogDebug("Other Middleware Log");
            await next(context);

        }
    }
}
