using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class addDataAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 5, 14, 40, 16, 666, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 5, 14, 40, 16, 671, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
