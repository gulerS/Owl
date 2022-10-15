﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OwlSchool.Persistence.Contexts;

#nullable disable

namespace OwlSchool.Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20221015200956_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OwlSchool.Domain.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Floor")
                        .HasColumnType("int")
                        .HasColumnName("Floor");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Class", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Floor = 1,
                            Name = "Science 1"
                        },
                        new
                        {
                            Id = 2,
                            Floor = 2,
                            Name = "Science 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
