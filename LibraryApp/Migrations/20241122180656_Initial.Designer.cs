﻿// <auto-generated />
using LibraryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LibraryApp.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241122180656_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LibraryApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "F. Scott Fitzgerald",
                            Genre = "Fiction",
                            Publisher = "Scribner",
                            Title = "The Great Gatsby",
                            Year = 1925
                        },
                        new
                        {
                            Id = 2,
                            Author = "George Orwell",
                            Genre = "Dystopian",
                            Publisher = "Secker & Warburg",
                            Title = "1984",
                            Year = 1949
                        },
                        new
                        {
                            Id = 3,
                            Author = "Harper Lee",
                            Genre = "Fiction",
                            Publisher = "J.B. Lippincott & Co.",
                            Title = "To Kill a Mockingbird",
                            Year = 1960
                        },
                        new
                        {
                            Id = 4,
                            Author = "Herman Melville",
                            Genre = "Adventure",
                            Publisher = "Harper & Brothers",
                            Title = "Moby-Dick",
                            Year = 1851
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
