using Microsoft.EntityFrameworkCore.Migrations;

namespace BookASPAssignment.Migrations
{
    public partial class addedExtentionCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Borrows",
                table: "Borrows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Borrows",
                newName: "borrows");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "book");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "author");

            migrationBuilder.AddColumn<int>(
                name: "ExtentionCount",
                table: "borrows",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_borrows",
                table: "borrows",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_book",
                table: "book",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_author",
                table: "author",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_borrows",
                table: "borrows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_book",
                table: "book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_author",
                table: "author");

            migrationBuilder.DropColumn(
                name: "ExtentionCount",
                table: "borrows");

            migrationBuilder.RenameTable(
                name: "borrows",
                newName: "Borrows");

            migrationBuilder.RenameTable(
                name: "book",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "author",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borrows",
                table: "Borrows",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "ID");
        }
    }
}
