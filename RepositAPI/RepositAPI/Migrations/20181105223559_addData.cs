using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Jeff" },
                    { 2, "Kendra" },
                    { 3, "Richard" },
                    { 4, "Allisa" },
                    { 5, "Jeremy" }
                });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "ID", "AuthorID", "CodeBody", "DateCreated", "Language", "Notes", "Title" },
                values: new object[] { 1, 1, "Console.WriteLine(\"Hello World!\")", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "This is cool.", "Hello World console writeline" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "ID", "AuthorID", "CodeBody", "DateCreated", "Language", "Notes", "Title" },
                values: new object[] { 2, 2, "Print(\"Hello World!\")", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "This is cooler", "Hello World python" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
