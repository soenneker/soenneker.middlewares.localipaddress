using Microsoft.AspNetCore.Builder;

namespace Soenneker.Middlewares.LocalIpAddress.Registrars;

/// <summary>
/// Middleware that sets both the local and remote IP addresses of the incoming HTTP context to 127.0.0.1 before invoking the next delegate in the request pipeline.
/// </summary>
public static class LocalIpAddressMiddlewareRegistrar
{
    /// <summary>
    /// Executes the use local ip address operation.
    /// </summary>
    /// <param name="builder">The builder.</param>
    /// <returns>The result of the operation.</returns>
    public static IApplicationBuilder UseLocalIpAddress(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<LocalIpAddressMiddleware>();
    }
}
