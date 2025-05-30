﻿// <auto-generated />
using System;
using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250523090925_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Went Hiking with Joe and Anne!",
                            Created = new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Went Hiking"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Went Shopping with my imaginary girlfriend!",
                            Created = new DateTime(2024, 5, 2, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Title = "Went Shopping"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Went Diving with Joe!",
                            Created = new DateTime(2024, 5, 3, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            Title = "Went Diving"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Walked some 385,000 kilometers. Leg Day.",
                            Created = new DateTime(2002, 8, 16, 7, 55, 22, 0, DateTimeKind.Unspecified),
                            Title = "Walking to the Moon."
                        },
                        new
                        {
                            Id = 5,
                            Content = "Scrapping my Rolls Royce.",
                            Created = new DateTime(2030, 4, 15, 2, 10, 0, 0, DateTimeKind.Unspecified),
                            Title = "Visiting Mechanic Claude."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
