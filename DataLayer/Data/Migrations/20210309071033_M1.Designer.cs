﻿// <auto-generated />
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210309071033_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = "b01d8893-8c7d-45f0-b7ef-c481536a35cd",
                            FirstName = "Jane",
                            LastName = "Smith",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = "88cf53cd-ce3d-46ed-bbeb-3312dff45dbf",
                            FirstName = "John",
                            LastName = "Fisher",
                            School = "Engineering"
                        },
                        new
                        {
                            StudentId = "3e974266-cee4-4a0e-99d5-5d67b8345eb1",
                            FirstName = "Pamela",
                            LastName = "Baker",
                            School = "Food Science"
                        },
                        new
                        {
                            StudentId = "bc139a10-e982-45d8-8d8e-42b23be274cc",
                            FirstName = "Peter",
                            LastName = "Taylor",
                            School = "Mining"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
