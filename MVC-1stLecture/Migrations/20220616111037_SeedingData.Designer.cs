﻿// <auto-generated />
using MVC_1stLecture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_1stLecture.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220616111037_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC_1stLecture.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "Laptop",
                            Price = 150.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Yellow socks",
                            Price = 290.89999999999998
                        },
                        new
                        {
                            Id = 4,
                            Name = "Green hat",
                            Price = 500.0
                        },
                        new
                        {
                            Id = 5,
                            Name = "T-shirt",
                            Price = 400.0
                        },
                        new
                        {
                            Id = 6,
                            Name = "Tie",
                            Price = 560.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}