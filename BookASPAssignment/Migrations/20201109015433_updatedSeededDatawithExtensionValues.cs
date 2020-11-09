using Microsoft.EntityFrameworkCore.Migrations;

namespace BookASPAssignment.Migrations
{
    public partial class updatedSeededDatawithExtensionValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "borrows",
                keyColumn: "ID",
                keyValue: -13,
                column: "ExtentionCount",
                value: 3);

            migrationBuilder.UpdateData(
                table: "borrows",
                keyColumn: "ID",
                keyValue: -9,
                column: "ExtentionCount",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "borrows",
                keyColumn: "ID",
                keyValue: -13,
                column: "ExtentionCount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "borrows",
                keyColumn: "ID",
                keyValue: -9,
                column: "ExtentionCount",
                value: 0);
        }
    }
}
