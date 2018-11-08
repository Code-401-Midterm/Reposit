using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class seedFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"public class Node
{
    public object Value { get; set; }
    public Node Right { get; set; }
    public Node Left { get; set; }

    public Node(object value)
    {
        Value = value;
    }
}", new DateTime(2018, 11, 7, 16, 28, 22, 371, DateTimeKind.Local) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"public class Node
                                {
                                    public object Value { get; set; }
                                    public Node Right { get; set; }
                                    public Node Left { get; set; }

                                    public Node(object value)
                                    {
                                        Value = value;
                                    }
                                }", new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local) });

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
                column: "Date",
                value: new DateTime(2018, 11, 7, 14, 7, 2, 478, DateTimeKind.Local));

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
    }
}
