﻿using AraujoMaterialConstrucao.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AraujoMaterialConstrucao.Data;

public class MaterialConstructionDbContext : IdentityDbContext
{
    public DbSet<Tile> Tile { get; set; }
    public DbSet<Brand> Brand { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();

        string conn = config.GetConnectionString("Conn");

        optionsBuilder.UseSqlServer(conn);
    }
}
