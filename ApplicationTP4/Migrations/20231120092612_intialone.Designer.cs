﻿// <auto-generated />
using System;
using ApplicationTP4_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplicationTP4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231120092612_intialone")]
    partial class intialone
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationTP4.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MembershiptypesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MembershiptypesId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ApplicationTP4.Models.Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ApplicationTP4.Models.Membershiptypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("DiscountRate")
                        .HasColumnType("real");

                    b.Property<float>("DurationInMonth")
                        .HasColumnType("real");

                    b.Property<float>("Signupfee")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Membershiptypes");
                });

            modelBuilder.Entity("ApplicationTP4.Models.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("genres_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("genres_Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CustomersMovies", b =>
                {
                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("CustomersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CustomersMovies");
                });

            modelBuilder.Entity("ApplicationTP4.Models.Customers", b =>
                {
                    b.HasOne("ApplicationTP4.Models.Membershiptypes", "Membershiptypes")
                        .WithMany("Customers")
                        .HasForeignKey("MembershiptypesId");

                    b.Navigation("Membershiptypes");
                });

            modelBuilder.Entity("ApplicationTP4.Models.Movies", b =>
                {
                    b.HasOne("ApplicationTP4.Models.Genres", "Genres")
                        .WithMany("Movies")
                        .HasForeignKey("genres_Id");

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("CustomersMovies", b =>
                {
                    b.HasOne("ApplicationTP4.Models.Customers", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationTP4.Models.Movies", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationTP4.Models.Genres", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("ApplicationTP4.Models.Membershiptypes", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
