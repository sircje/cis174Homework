﻿// <auto-generated />
using CIS174_TestCoreApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIS174_TestCoreApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191028045941_InitialSchema")]
    partial class InitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIS174_TestCoreApp.Models.FamousPeople", b =>
                {
                    b.Property<int>("FamousPeopleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("birthDate");

                    b.Property<string>("city");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("state");

                    b.HasKey("FamousPeopleId");

                    b.ToTable("FamousPeoples");
                });
#pragma warning restore 612, 618
        }
    }
}