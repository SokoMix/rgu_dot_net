using RGU.WebProgramming.Server.PostgresStorage;
using RGU.WebProgramming.Core.Interfaces;

namespace RGU.WebProgramming.Server.DataProvider;

public class DbContextFactory:
    IAbstractFactory<PostgresStorage.PostgresStorage>
{
    
    // TODO: constructor from IOptions<DbContextFactorySettings>

    public PostgresStorage.PostgresStorage Create()
    {
        return new PostgresStorage.PostgresStorage();
    }
    
}