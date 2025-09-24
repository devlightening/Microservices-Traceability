using AspNetCoreApp.Middlewares;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

#region NLog Setup

builder.Logging.ClearProviders();
builder.Host.UseNLog();

#endregion 

var app = builder.Build();

app.UseMiddleware<CorrelationMiddleware>();
app.UseMiddleware<OtherMiddleware>();


app.MapGet("/", (HttpContext context, ILogger<Program> logger) =>
{
    var correlationId = context.Request.Headers["X-Correlation-ID"].FirstOrDefault();
    //YA DA 

    correlationId = context.Items["CorrelationId"].ToString();

    NLog.MappedDiagnosticsContext.Set("CorrelationId", correlationId);
    logger.LogDebug("Minimum API Log");

});

app.Run();
