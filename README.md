[![](https://img.shields.io/nuget/v/soenneker.middlewares.localipaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.middlewares.localipaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.middlewares.localipaddress/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.middlewares.localipaddress/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.middlewares.localipaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.middlewares.localipaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.middlewares.localipaddress/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.middlewares.localipaddress/actions/workflows/codeql.yml)

# Soenneker.Middlewares.LocalIpAddress

Middleware that sets both the local and remote IP addresses of the incoming HTTP context to 127.0.0.1 before invoking the next delegate in the request pipeline.

## Install

```bash
dotnet add package Soenneker.Middlewares.LocalIpAddress
```

## Quick start

```csharp
using Soenneker.Middlewares.LocalIpAddress.Registrars;

IApplicationBuilder builder = /* obtain from your application */;
var result = builder.UseLocalIpAddress();
```

Adds the use local ip address local ip address middleware utility to the class list.

## What you get

- `ILocalIpAddressMiddleware` — Middleware that sets both the local and remote IP addresses of the incoming HTTP context to 127.0.0.1 before invoking the next delegate in the request pipeline.
- `LocalIpAddressMiddlewareRegistrar` — Middleware that sets both the local and remote IP addresses of the incoming HTTP context to 127.0.0.1 before invoking the next delegate in the request pipeline.
- `LocalIpAddressMiddleware` — Middleware that replaces both endpoint IP addresses with the loopback address before passing the request to the next delegate.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `LocalIpAddressMiddlewareRegistrar.UseLocalIpAddress(builder)` | Adds the use local ip address local ip address middleware utility to the class list. | The same builder instance, so additional classes or variants can be chained. |
| `LocalIpAddressMiddleware.Invoke(httpContext)` | Invokes the local ip address middleware with the supplied payload. | A task that completes when the callback has finished running. |
