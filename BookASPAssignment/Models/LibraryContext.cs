using System;
using System.Collections.Generic;

using System.Text;

using Microsoft.EntityFrameworkCore;


namespace BookASPAssignment.Models
{
    public class LibraryContext : DbContext
    
    {

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connection =
                    "server=localhost;" +
                    "port=3306;" +
                    "user=root;" +
                    "database=mvc_library;";
                string version = "10.4.14-MariaDB";

                optionsBuilder.UseMySql(connection, x => x.ServerVersion(version));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Name)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");

                entity.HasData(
                    new Author()
                    {
                        ID = -1,
                        Name = "William Shakespare",
                        DateOfBirth = new DateTime(1912,01,31),
                        DeathDate = new DateTime(1970, 12,25)
                        

                    },
                     new Author()
                     {
                         ID = -2,
                         Name = "William Etinburgh",
                         DateOfBirth = new DateTime(1812, 01, 31),
                         DeathDate = new DateTime(1870, 12, 25)


                     },
                      new Author()
                      {
                          ID = -3,
                          Name = "John Milton",
                          DateOfBirth = new DateTime(1910, 01, 31),
                          DeathDate = new DateTime(1980, 12, 25)


                      },
                      new Author()
                      {
                          ID = -4,
                          Name = "Micheal Johnson",
                          DateOfBirth = new DateTime(1710, 01, 31),
                          DeathDate = new DateTime(1780, 12, 25)


                      },
                      new Author()
                      {
                          ID = -5,
                          Name = "Micheal Bublo",
                          DateOfBirth = new DateTime(1870, 01, 31),
                          DeathDate = new DateTime(1980, 01, 25)


                      }


                    );
            });

            modelBuilder.Entity<Book>(entity =>
            {
               

                string keyName = "FK_" + nameof(Book) +
                    "_" + nameof(Author);

                entity.Property(e => e.Title)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");

                entity.HasIndex(e => e.AuthorID)
                .HasName(keyName);

                entity.HasOne(thisEntity => thisEntity.Author)
               .WithMany(parent => parent.Books)
               .HasForeignKey(thisEntity => thisEntity.AuthorID)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName(keyName);

                entity.HasData(
                    new Book()
                    {
                        ID = -1,
                        Title = "The Chronicles of Tommorow",
                        PublicationDate = new DateTime(1930, 05,31),
                        AuthorID = -1

                    },
                    new Book()
                    {
                        ID = -2,
                        Title = "The Lucy",
                        PublicationDate = new DateTime(1931, 05, 31),
                        AuthorID = -1

                    },
                    new Book()
                    {
                        ID = -3,
                        Title = "Love is Crazy",
                        PublicationDate = new DateTime(1932, 05, 31),
                        AuthorID = -1

                    },
                    new Book()
                    {
                        ID = -4,
                        Title = "Dawn till dusk",
                        PublicationDate = new DateTime(1866, 05, 31),
                        AuthorID = -2

                    },
                    new Book()
                    {
                        ID = -5,
                        Title = "The Label Game",
                        PublicationDate = new DateTime(1850, 05, 01),
                        AuthorID = -2

                    },
                    new Book()
                    {
                        ID = -6,
                        Title = "The Mary",
                        PublicationDate = new DateTime(1840, 05, 22),
                        AuthorID = -2

                    },
                    new Book()
                    {
                        ID = -7,
                        Title = "How I met your mother",
                        PublicationDate = new DateTime(1970, 12, 25),
                        AuthorID = -3

                    },
                    new Book()
                    {
                        ID = -8,
                        Title = "Last day of Knowledge",
                        PublicationDate = new DateTime(1950, 11, 01),
                        AuthorID = -3

                    },
                    new Book()
                    {
                        ID = -9,
                        Title = "The war stories",
                        PublicationDate = new DateTime(1940, 01, 31),
                        AuthorID = -3

                    },
                    new Book()
                    {
                        ID = -10,
                        Title = "The Lion",
                        PublicationDate = new DateTime(1745, 03, 29),
                        AuthorID = -4

                    },
                    new Book()
                    {
                        ID = -11,
                        Title = "The Giraffe",
                        PublicationDate = new DateTime(1735, 05, 06),
                        AuthorID = -4

                    },
                    new Book()
                    {
                        ID = -12,
                        Title = "Why is Giraffe so tall",
                        PublicationDate = new DateTime(1750, 01, 18),
                        AuthorID = -4

                    },
                    new Book()
                    {
                        ID = -13,
                        Title = "Lovely Days",
                        PublicationDate = new DateTime(1945, 05, 05),
                        AuthorID = -5

                    },
                    new Book()
                    {
                        ID = -14,
                        Title = "Midnight Cravings",
                        PublicationDate = new DateTime(1950, 10, 29),
                        AuthorID = -5

                    },
                    new Book()
                    {
                        ID = -15,
                        Title = "Lonely Stories",
                        PublicationDate = new DateTime(1920, 05, 31),
                        AuthorID = -5

                    }

                    );
            });






            modelBuilder.Entity<Borrow>(entity =>
            {


                string keyBorrow = "FK_" + nameof(Borrow) +
                    "_" + nameof(Book);

                entity.HasIndex(e => e.BookID)
                .HasName(keyBorrow);

                entity.HasOne(thisEntity => thisEntity.Book)
                .WithMany(parent => parent.Borrows)
                .HasForeignKey(thisEntity => thisEntity.BookID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName(keyBorrow);
                entity.HasData(

                    new Borrow()
                    {
                        ID = -1,
                        BookID = -1,
                        CheckedOutDate = new DateTime(2019, 12, 25),
                        ReturnedDate = new DateTime(2020, 02, 02),
                        DueDate = new DateTime(2020, 11, 17),
                        ExtentionCount = 0
                    },
                    new Borrow()
                    {
                        ID = -2,
                        BookID = -2,
                        CheckedOutDate = new DateTime(2019, 12, 25),
                        ReturnedDate = new DateTime(2020, 02, 02),
                        DueDate = new DateTime(2020, 11, 17),
                        ExtentionCount = 0
                    },
                    new Borrow()
                    {
                        ID = -3,
                        BookID = -3,
                        CheckedOutDate = new DateTime(2020, 07, 21),
                        ReturnedDate = new DateTime(2020, 02, 02),
                        DueDate = new DateTime(2020, 11, 17),
                        ExtentionCount = 0
                    },
                     new Borrow()
                     {
                         ID = -4,
                         BookID = -4,
                         CheckedOutDate = new DateTime(2020, 07, 21),
                         ReturnedDate = new DateTime(2020, 02, 02),
                         DueDate = new DateTime(2020, 11, 17),
                         ExtentionCount = 0
                     },
                      new Borrow()
                      {
                          ID = -5,
                          BookID = -5,
                          CheckedOutDate = new DateTime(2019, 12, 25),
                          ReturnedDate = new DateTime(2020, 02, 02),
                          DueDate = new DateTime(2020, 11, 17),
                          ExtentionCount = 0
                      },
                       new Borrow()
                       {
                           ID = -6,
                           BookID = -6,
                           CheckedOutDate = new DateTime(2020, 07, 21),
                           ReturnedDate = new DateTime(2020, 02, 02),
                           DueDate = new DateTime(2020, 11, 30),
                           ExtentionCount = 0
                       },
                        new Borrow()
                        {
                            ID = -7,
                            BookID = -7,
                            CheckedOutDate = new DateTime(2020, 07, 21),
                            ReturnedDate = new DateTime(2020, 02, 02),
                            DueDate = new DateTime(2020, 11, 30),
                            ExtentionCount = 0
                        }, new Borrow()
                        {
                            ID = -8,
                            BookID = -8,
                            CheckedOutDate = new DateTime(2020, 07, 21),
                            ReturnedDate = new DateTime(2020, 02, 02),
                            DueDate = new DateTime(2020, 11, 17),
                            ExtentionCount = 0
                        },
                         new Borrow()
                         {
                             ID = -9,
                             BookID = -9,
                             CheckedOutDate = new DateTime(2020, 07, 21),
                             ReturnedDate = new DateTime(2020, 02, 02),
                             DueDate = new DateTime(2020, 11, 30),
                             ExtentionCount = 1
                         },
                          new Borrow()
                          {
                              ID = -10,
                              BookID = -10,
                              CheckedOutDate = new DateTime(2020, 07, 21),
                              ReturnedDate = new DateTime(2020, 02, 02),
                              DueDate = new DateTime(2020, 11, 17),
                              ExtentionCount = 0
                          },
                           new Borrow()
                           {
                               ID = -11,
                               BookID = -12,
                               CheckedOutDate = new DateTime(2020, 07, 21),
                               ReturnedDate = new DateTime(2020, 02, 02),
                               DueDate = new DateTime(2020, 11, 17),
                               ExtentionCount = 0
                           },
                            new Borrow()
                            {
                                ID = -12,
                                BookID = -13,
                                CheckedOutDate = new DateTime(2020, 07, 21),
                                ReturnedDate = new DateTime(2020, 02, 02),
                                DueDate = new DateTime(2020, 11, 17),
                                ExtentionCount = 0
                            },
                             new Borrow()
                             {
                                 ID = -13,
                                 BookID = -11,
                                 CheckedOutDate = new DateTime(2020, 07, 21),
                                 ReturnedDate = new DateTime(2020, 02, 02),
                                 DueDate = new DateTime(2020, 11, 17),
                                 ExtentionCount = 3
                             },
                             new Borrow()
                             {
                                 ID = -14,
                                 BookID = -15,
                                 CheckedOutDate = new DateTime(2020, 07, 21),
                                 ReturnedDate = new DateTime(2020, 02, 02),
                                 DueDate = new DateTime(2020, 11, 17),
                                 ExtentionCount = 0
                             },
                             new Borrow()
                             {
                                 ID = -15,
                                 BookID = -12,
                                 CheckedOutDate = new DateTime(2020, 07, 21),
                                 ReturnedDate = new DateTime(2020, 02, 02),
                                 DueDate = new DateTime(2020, 11, 17),
                                 ExtentionCount = 0
                             }




  )  ; 
            });
        }
    }
}
