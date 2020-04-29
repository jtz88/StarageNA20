using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarageNA20.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Product",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "OrderDate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, "Mobile", 156, "Stupid", "Iphone", new DateTime(2020, 4, 23, 13, 50, 19, 282, DateTimeKind.Local).AddTicks(3991), 15600, "4B" },
                    { 2, "Mobile", 98, "Better", "S10", new DateTime(2020, 4, 6, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1528), 12450, "4C" },
                    { 3, "Computers", 23, "Stupid", "MacBook", new DateTime(2020, 4, 24, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1596), 45600, "4C" },
                    { 4, "Computer", 32, "Stupid", "Suface X", new DateTime(2020, 3, 20, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1603), 26850, "5C" },
                    { 5, "Office Supplies", 15651, "Stupid", "Pen", new DateTime(2020, 4, 23, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1607), 1, "45W" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Product");
        }
    }
}
