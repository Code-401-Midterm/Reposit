using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class fixTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 240, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 30, 54, 242, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 369, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local));
        }
    }
}
