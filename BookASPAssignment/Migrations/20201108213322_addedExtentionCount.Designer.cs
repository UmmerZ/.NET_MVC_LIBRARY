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
    [Migration("20201108213322_addedExtentionCount")]
    partial class addedExtentionCount
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

                    b.ToTable("author");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            DateOfBirth = new DateTime(1912, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1970, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "William Shakespare"
                        },
                        new
                        {
                            ID = -2,
                            DateOfBirth = new DateTime(1812, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1870, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "William Etinburgh"
                        },
                        new
                        {
                            ID = -3,
                            DateOfBirth = new DateTime(1910, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Milton"
                        },
                        new
                        {
                            ID = -4,
                            DateOfBirth = new DateTime(1710, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1780, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Micheal Johnson"
                        },
                        new
                        {
                            ID = -5,
                            DateOfBirth = new DateTime(1870, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1980, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Micheal Bublo"
                        });
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

                    b.HasIndex("AuthorID")
                        .HasName("FK_Book_Author");

                    b.ToTable("book");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            AuthorID = -1,
                            PublicationDate = new DateTime(1930, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Chronicles of Tommorow"
                        },
                        new
                        {
                            ID = -2,
                            AuthorID = -1,
                            PublicationDate = new DateTime(1931, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Lucy"
                        },
                        new
                        {
                            ID = -3,
                            AuthorID = -1,
                            PublicationDate = new DateTime(1932, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Love is Crazy"
                        },
                        new
                        {
                            ID = -4,
                            AuthorID = -2,
                            PublicationDate = new DateTime(1866, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Dawn till dusk"
                        },
                        new
                        {
                            ID = -5,
                            AuthorID = -2,
                            PublicationDate = new DateTime(1850, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Label Game"
                        },
                        new
                        {
                            ID = -6,
                            AuthorID = -2,
                            PublicationDate = new DateTime(1840, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Mary"
                        },
                        new
                        {
                            ID = -7,
                            AuthorID = -3,
                            PublicationDate = new DateTime(1970, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "How I met your mother"
                        },
                        new
                        {
                            ID = -8,
                            AuthorID = -3,
                            PublicationDate = new DateTime(1950, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Last day of Knowledge"
                        },
                        new
                        {
                            ID = -9,
                            AuthorID = -3,
                            PublicationDate = new DateTime(1940, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The war stories"
                        },
                        new
                        {
                            ID = -10,
                            AuthorID = -4,
                            PublicationDate = new DateTime(1745, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Lion"
                        },
                        new
                        {
                            ID = -11,
                            AuthorID = -4,
                            PublicationDate = new DateTime(1735, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Giraffe"
                        },
                        new
                        {
                            ID = -12,
                            AuthorID = -4,
                            PublicationDate = new DateTime(1750, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Why is Giraffe so tall"
                        },
                        new
                        {
                            ID = -13,
                            AuthorID = -5,
                            PublicationDate = new DateTime(1945, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Lovely Days"
                        },
                        new
                        {
                            ID = -14,
                            AuthorID = -5,
                            PublicationDate = new DateTime(1950, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Midnight Cravings"
                        },
                        new
                        {
                            ID = -15,
                            AuthorID = -5,
                            PublicationDate = new DateTime(1920, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Lonely Stories"
                        });
                });

            modelBuilder.Entity("BookASPAssignment.Models.Borrow", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<int>("BookID")
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("CheckedOutDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("date");

                    b.Property<int>("ExtentionCount")
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("ReturnedDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.HasIndex("BookID")
                        .HasName("FK_Borrow_Book");

                    b.ToTable("borrows");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            BookID = -1,
                            CheckedOutDate = new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -2,
                            BookID = -2,
                            CheckedOutDate = new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -3,
                            BookID = -3,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -4,
                            BookID = -4,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -5,
                            BookID = -5,
                            CheckedOutDate = new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -6,
                            BookID = -6,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -7,
                            BookID = -7,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -8,
                            BookID = -8,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -9,
                            BookID = -9,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -10,
                            BookID = -10,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -11,
                            BookID = -12,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -12,
                            BookID = -13,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -13,
                            BookID = -11,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -14,
                            BookID = -15,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = -15,
                            BookID = -12,
                            CheckedOutDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtentionCount = 0,
                            ReturnedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookASPAssignment.Models.Book", b =>
                {
                    b.HasOne("BookASPAssignment.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
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
