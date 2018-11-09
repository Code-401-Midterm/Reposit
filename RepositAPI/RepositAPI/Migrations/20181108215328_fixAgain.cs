using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class fixAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CodeBody",
                value: @"
Console.WriteLine(""Hello World!"")");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "CodeBody",
                value: @"
Print(""Hello World!"")");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Title",
                value: ".Map()");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "CodeBody",
                value: @"
public int numUniqueEmails(String[] emails) 
{
    Set<String> seen = new HashSet();
    for (String email: emails)
    {
        int i = email.indexOf('@');
        String local = email.substring(0, i);
        String rest = email.substring(i);
        if (local.contains(""+""))
        {
            local = local.substring(0, local.indexOf('+'));
        }
        local = local.replaceAll(""."", "");
        seen.add(local + rest);
    }

    return seen.size();
}");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "CodeBody",
                value: @"
SELECT * FROM myTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CodeBody",
                value: "Console.WriteLine(\"Hello World!\")");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "CodeBody",
                value: "Print(\"Hello World!\")");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Title",
                value: "Array.Prototype.Map()");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "CodeBody",
                value: @"
public int numUniqueEmails(String[] emails) 
{
    Set<String> seen = new HashSet();
    for (String email: emails)
    {
        int i = email.indexOf('@');
        String local = email.substring(0, i);
        String rest = email.substring(i);
        if (local.contains(""+""))
        {
            local = local.substring(0, local.indexOf('+'));
        }
        local = local.replaceAll(""."", "");
        seen.add(local + rest);
    }

    return seen.size();
}");

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "CodeBody",
                value: "SELECT * FROM myTable");
        }
    }
}
