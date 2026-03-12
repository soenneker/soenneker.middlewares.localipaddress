using Soenneker.Middlewares.LocalIpAddress.Abstract;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Soenneker.Middlewares.LocalIpAddress;

/// <inheritdoc cref="ILocalIpAddressMiddleware"/>
public sealed class LocalIpAddressMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IPAddress _fakeIpAddress = IPAddress.Loopback;

    public LocalIpAddressMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public Task Invoke(HttpContext httpContext)
    {
        httpContext.Connection.LocalIpAddress = _fakeIpAddress;
        httpContext.Connection.RemoteIpAddress = _fakeIpAddress;

        return _next(httpContext);
    }
}