﻿// <auto-generated />
using System;
using AraujoMaterialConstrucao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AraujoMaterialConstrucao.Data.Migrations
{
    [DbContext(typeof(MaterialConstructionDbContext))]
    partial class MaterialConstructionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AraujoMaterialConstrucao.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("AraujoMaterialConstrucao.Models.Tile", b =>
                {
                    b.Property<int>("TileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TileId"));

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(175)
                        .HasColumnType("nvarchar(175)");

                    b.Property<bool>("ExpressDelivery")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TileId");

                    b.HasIndex("BrandId");

                    b.ToTable("Tile");
                });

            modelBuilder.Entity("AraujoMaterialConstrucao.Models.Tile", b =>
                {
                    b.HasOne("AraujoMaterialConstrucao.Models.Brand", null)
                        .WithMany("Tiles")
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("AraujoMaterialConstrucao.Models.Brand", b =>
                {
                    b.Navigation("Tiles");
                });
#pragma warning restore 612, 618
        }
    }
}
