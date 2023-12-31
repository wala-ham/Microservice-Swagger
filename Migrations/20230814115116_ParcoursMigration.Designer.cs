﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testswagger.Data;

#nullable disable

namespace testswagger.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230814115116_ParcoursMigration")]
    partial class ParcoursMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("testswagger.Domain.Models.Parcour", b =>
                {
                    b.Property<int>("ParcoursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParcoursId"), 1L, 1);

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParcoursDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParcoursName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParcoursId");

                    b.ToTable("Parcourslist");
                });
#pragma warning restore 612, 618
        }
    }
}
