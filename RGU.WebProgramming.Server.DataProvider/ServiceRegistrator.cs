using DryIoc;
using Microsoft.Extensions.Configuration;
using RGU.WebProgramming.Server.Core;

namespace RGU.WebProgramming.Server.DataProvider;

public sealed class ServiceRegistrator:
    IServiceRegistrator
{
    public void Register(
        IRegistrator registrator,
        IConfiguration configuration)
    {
        registrator.Register<DbContextFactory>(Reuse.Singleton);
    }
}