﻿using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;

using RGU.WebProgramming.Server.Core;
using RGU.WebProgramming.Server.REST.API.Settings;

namespace RGU.WebProgramming.Server.REST.API;

/// <summary>
/// 
/// </summary>
public sealed class WebHostConfigurator:
    IWebHostConfigurator
{
    
    #region RGU.WebProgramming.Server.Core.IWebHostConfigurator implementation

    /// <inheritdoc cref="IWebHostConfigurator.Configure" />
    public void Configure(
        IWebHostBuilder webHostBuilder)
    {
        webHostBuilder
            .ConfigureKestrel((context, options) =>
            {
                var serverSettings = new ServerSettings();
                context.Configuration.Bind(nameof(ServerSettings), serverSettings);

                options.Listen(
                    IPAddress.Parse(serverSettings.ListenAddress),
                    serverSettings.ListenPort,
                    listenOptions =>
                    {
                        listenOptions.Protocols = HttpProtocols.Http1;
                        // listenOptions.UseHttps(serverSettings.CertPath, serverSettings.CertPassword);
                    });
            });
    }
    
    #endregion
    
}