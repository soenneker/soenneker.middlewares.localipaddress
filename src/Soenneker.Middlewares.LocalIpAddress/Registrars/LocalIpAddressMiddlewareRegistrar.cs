using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Soenneker.Middlewares.LocalIpAddress.Registrars;

/// <summary>
/// Registers loopback-address rewriting for development and test hosts.
/// </summary>
public static class LocalIpAddressMiddlewareRegistrar
{
    /// <summary>
    /// Adds loopback-address rewriting to the application pipeline.
    /// </summary>
    /// <param name="builder">Application builder to configure.</param>
    /// <returns>The same builder instance, so additional middleware can be chained.</returns>
    /// <exception cref="InvalidOperationException">The host environment is neither Development nor Testing.</exception>
    public static IApplicationBuilder UseLocalIpAddress(this IApplicationBuilder builder)
    {
        IHostEnvironment environment = builder.ApplicationServices.GetRequiredService<IHostEnvironment>();

        if (!environment.IsDevelopment() && !environment.IsEnvironment("Testing"))
        {
            throw new InvalidOperationException(
                "Local IP address rewriting is restricted to Development and Testing environments because it bypasses IP-based security decisions.");
        }

        return builder.UseMiddleware<LocalIpAddressMiddleware>();
    }
}
