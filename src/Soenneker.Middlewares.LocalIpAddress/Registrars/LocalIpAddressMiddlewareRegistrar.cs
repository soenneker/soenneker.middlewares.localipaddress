using Microsoft.AspNetCore.Builder;

namespace Soenneker.Middlewares.LocalIpAddress.Registrars;

/// <summary>
/// Middleware that sets both the local and remote IP addresses of the incoming HTTP context to 127.0.0.1 before invoking the next delegate in the request pipeline.
/// </summary>
public static class LocalIpAddressMiddlewareRegistrar
{
    /// <summary>
    /// Adds the use local ip address local ip address middleware utility to the class list.
    /// </summary>
    /// <param name="builder">Builder to configure.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static IApplicationBuilder UseLocalIpAddress(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<LocalIpAddressMiddleware>();
    }
}
