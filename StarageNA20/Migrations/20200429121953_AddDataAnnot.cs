using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarageNA20.Migrations
{
    public partial class AddDataAnnot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 23, 14, 19, 53, 168, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 4, 6, 14, 19, 53, 171, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 4, 24, 14, 19, 53, 171, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2020, 3, 20, 14, 19, 53, 171, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2020, 4, 23, 14, 19, 53, 171, DateTimeKind.Local).AddTicks(4366));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 23, 13, 50, 19, 282, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 4, 6, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 4, 24, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2020, 3, 20, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2020, 4, 23, 13, 50, 19, 286, DateTimeKind.Local).AddTicks(1607));
        }
    }
}
