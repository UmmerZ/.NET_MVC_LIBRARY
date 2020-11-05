using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookASPAssignment.Migrations
{
    public partial class seedingMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "ID", "DateOfBirth", "DeathDate", "Name" },
                values: new object[,]
                {
                    { -1, new DateTime(1912, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Shakespare" },
                    { -2, new DateTime(1812, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1870, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Etinburgh" },
                    { -3, new DateTime(1910, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Milton" },
                    { -4, new DateTime(1710, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1780, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Micheal Johnson" },
                    { -5, new DateTime(1870, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Micheal Bublo" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "ID", "AuthorID", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { -1, -1, new DateTime(1930, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Chronicles of Tommorow" },
                    { -2, -1, new DateTime(1931, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lucy" },
                    { -3, -1, new DateTime(1932, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love is Crazy" },
                    { -4, -2, new DateTime(1866, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dawn till dusk" },
                    { -5, -2, new DateTime(1850, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Label Game" },
                    { -6, -2, new DateTime(1840, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mary" },
                    { -7, -3, new DateTime(1970, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "How I met your mother" },
                    { -8, -3, new DateTime(1950, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Last day of Knowledge" },
                    { -9, -3, new DateTime(1940, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The war stories" },
                    { -10, -4, new DateTime(1745, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lion" },
                    { -11, -4, new DateTime(1735, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Giraffe" },
                    { -12, -4, new DateTime(1750, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why is Giraffe so tall" },
                    { -13, -5, new DateTime(1945, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lovely Days" },
                    { -14, -5, new DateTime(1950, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midnight Cravings" },
                    { -15, -5, new DateTime(1920, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lonely Stories" }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "ID", "BookID", "CheckedOutDate", "DueDate", "ReturnedDate" },
                values: new object[,]
                {
                    { -1, -1, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -2, -2, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -3, -3, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -4, -4, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -5, -5, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -6, -6, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -7, -7, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -8, -8, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -9, -9, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -10, -10, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -13, -11, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -11, -12, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -15, -12, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -12, -13, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -14, -15, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
