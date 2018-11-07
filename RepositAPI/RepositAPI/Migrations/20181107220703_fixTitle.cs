using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class fixTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 477, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Date", "Title" },
                values: new object[] { new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local), "Bubblesort" });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 760, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Date", "Title" },
                values: new object[] { new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), "" });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local));
        }
    }
}
