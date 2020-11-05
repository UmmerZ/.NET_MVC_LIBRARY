﻿// <auto-generated />
using System;
using BookASPAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookASPAssignment.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20201104231720_intialMigrations")]
    partial class intialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BookASPAssignment.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime>("DeathDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BookASPAssignment.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<int>("AuthorID")
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("BookASPAssignment.Models.Borrow", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("CheckedOutDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("ReturnedDate")
                        .HasColumnType("date");

                    b.HasKey("BookID");

                    b.HasIndex("BookID")
                        .HasName("FK_Borrow_Book");

                    b.ToTable("Borrows");
                });

            modelBuilder.Entity("BookASPAssignment.Models.Book", b =>
                {
                    b.HasOne("BookASPAssignment.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("ID")
                        .HasConstraintName("FK_Book_Author")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BookASPAssignment.Models.Borrow", b =>
                {
                    b.HasOne("BookASPAssignment.Models.Book", "Book")
                        .WithMany("Borrows")
                        .HasForeignKey("BookID")
                        .HasConstraintName("FK_Borrow_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}