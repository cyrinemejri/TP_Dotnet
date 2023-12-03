﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tp3.Models;

#nullable disable

namespace tp3.Migrations
{
    [DbContext(typeof(ApplicationdbContext))]
    [Migration("20231129012025_initm")]
    partial class initm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tp3.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("membershiptype_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("membershiptype_id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("tp3.Models.Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreName = "GenreFromJsonFile1"
                        },
                        new
                        {
                            Id = 2,
                            GenreName = "GenreFromJsonFile2"
                        });
                });

            modelBuilder.Entity("tp3.Models.Membershiptypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DiscountRate")
                        .HasColumnType("float");

                    b.Property<int>("DurationInMonth")
                        .HasColumnType("int");

                    b.Property<double>("SignUpFee")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("membershiptypes");
                });

            modelBuilder.Entity("tp3.Models.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomersId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Movie_Added")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("genre_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("genre_id");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("tp3.Models.Customers", b =>
                {
                    b.HasOne("tp3.Models.Membershiptypes", "Membershiptypes")
                        .WithMany("Customers")
                        .HasForeignKey("membershiptype_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membershiptypes");
                });

            modelBuilder.Entity("tp3.Models.Movies", b =>
                {
                    b.HasOne("tp3.Models.Customers", null)
                        .WithMany("Movies")
                        .HasForeignKey("CustomersId");

                    b.HasOne("tp3.Models.Genres", "Genres")
                        .WithMany("Movies")
                        .HasForeignKey("genre_id");

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("tp3.Models.Customers", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("tp3.Models.Genres", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("tp3.Models.Membershiptypes", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
