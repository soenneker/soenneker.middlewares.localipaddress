using Microsoft.AspNetCore.Http;
using Soenneker.Middlewares.LocalIpAddress.Abstract;
using System.Net;
using System.Threading.Tasks;

namespace Soenneker.Middlewares.LocalIpAddress;

/// <inheritdoc cref="ILocalIpAddressMiddleware" />
public sealed class LocalIpAddressMiddleware : ILocalIpAddressMiddleware
{
    private readonly RequestDelegate _next;

    public LocalIpAddressMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public Task Invoke(HttpContext httpContext)
    {
        httpContext.Connection.LocalIpAddress = IPAddress.Loopback;
        httpContext.Connection.RemoteIpAddress = IPAddress.Loopback;

        return _next(httpContext);
    }
}
