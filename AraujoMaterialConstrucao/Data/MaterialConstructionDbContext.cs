using Microsoft.EntityFrameworkCore;

namespace AraujoMaterialConstrucao.Data;

public class MaterialConstructionDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();

        string conn = config.GetConnectionString("Conn");

        optionsBuilder.UseSqlServer(conn);
    }
}
