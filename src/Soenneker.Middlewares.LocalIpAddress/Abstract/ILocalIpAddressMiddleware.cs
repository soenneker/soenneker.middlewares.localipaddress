using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Soenneker.Middlewares.LocalIpAddress.Abstract;

/// <summary>
/// Replaces the local and remote endpoint addresses with the IPv4 loopback address for test requests.
/// </summary>
public interface ILocalIpAddressMiddleware
{
    /// <summary>
    /// Rewrites the connection addresses and invokes the remaining request pipeline.
    /// </summary>
    /// <param name="httpContext">Current HTTP context.</param>
    /// <returns>A task that completes with the remaining request pipeline.</returns>
    Task Invoke(HttpContext httpContext);
}
