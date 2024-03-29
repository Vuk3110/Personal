﻿// <auto-generated />
using System;
using Baza;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Baza.Migrations
{
    [DbContext(typeof(ZeleznickaStanicaDbContext))]
    [Migration("20230829120721_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.Entiteti.Karta", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MestoDolaska")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MestoPolaska")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VremePolaska")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Karte");
                });
#pragma warning restore 612, 618
        }
    }
}
