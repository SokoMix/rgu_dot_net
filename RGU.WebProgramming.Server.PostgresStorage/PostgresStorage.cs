using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RGU.WebProgramming.Server.REST.Models;

namespace RGU.WebProgramming.Server.PostgresStorage;

public class PostgresStorage : DbContext
{

    #region Fields

    private readonly ILogger<PostgresStorage> _logger;

    // private readonly NpgsqlConnection _storage = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=mydb;");
    
    #endregion

    #region Tables

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<GiveBook> GiveBooks { get; set; }
    public DbSet<Publishing> Publishings { get; set; }
    public DbSet<Reader> Readers { get; set; }

    #endregion

    #region Microsoft.EntityFrameworkCore.DbContext overrides

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString:
            "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=mydb;"); 
        base.OnConfiguring(optionsBuilder);
    }

    #endregion
    
}