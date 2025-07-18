namespace Mini_Medical_Record_API.Middleware
{
    public class APIMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<APIMiddleware> _logger;

        public APIMiddleware(RequestDelegate next, ILogger<APIMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("Request Path: {Path}", context.Request.Path);
            await _next(context);
        }
    }
}
