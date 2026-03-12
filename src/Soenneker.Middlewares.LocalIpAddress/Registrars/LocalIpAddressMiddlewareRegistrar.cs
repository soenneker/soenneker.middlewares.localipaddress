using Microsoft.AspNetCore.Builder;

namespace Soenneker.Middlewares.LocalIpAddress.Registrars;

/// <summary>
/// Middleware that sets both the local and remote IP addresses of the incoming HTTP context to 127.0.0.1 before invoking the next delegate in the request pipeline.
/// </summary>
public static class LocalIpAddressMiddlewareRegistrar
{
    public static IApplicationBuilder UseLocalIpAddress(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<LocalIpAddressMiddleware>();
    }
}
