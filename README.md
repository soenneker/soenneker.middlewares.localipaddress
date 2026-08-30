# Soenneker.Middlewares.LocalIpAddress
[![](https://img.shields.io/nuget/v/soenneker.middlewares.localipaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.middlewares.localipaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.middlewares.localipaddress/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.middlewares.localipaddress/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.middlewares.localipaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.middlewares.localipaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.middlewares.localipaddress/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.middlewares.localipaddress/actions/workflows/codeql.yml)

Makes ASP.NET Core test requests appear to originate from IPv4 loopback by replacing both connection endpoint addresses with `127.0.0.1`.

## Installation

```bash
dotnet add package Soenneker.Middlewares.LocalIpAddress
```

## Test-host usage

Set the test host environment to `Testing` through the test host or `WebApplicationFactory` configuration. In the application pipeline, add the middleware before anything that reads the connection IP:

```csharp
using Soenneker.Middlewares.LocalIpAddress.Registrars;

app.UseForwardedHeaders();

if (app.Environment.IsEnvironment("Testing"))
    app.UseLocalIpAddress();

app.UseRateLimiter();
app.UseAuthorization();
app.MapControllers();
```

It may also run in the `Development` environment. Registration throws `InvalidOperationException` in every other environment.

Place it after forwarded-header processing; otherwise `UseForwardedHeaders` can overwrite the loopback value. Place it before authorization, rate limiting, auditing, or application code that reads `Connection.RemoteIpAddress`.

## Security boundary

This middleware deliberately destroys the real network identity and can make an external request pass loopback-only policies. Use it only in an isolated development or test host. Do not change a deployed environment name to bypass the registration guard.

Both local and remote addresses are always IPv4 loopback. Ports and forwarded-header values are not changed.
