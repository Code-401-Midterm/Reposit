using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class fixAgain2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        local = local.replaceAll(""."", """");
        seen.add(local + rest);
    }

    return seen.size();
}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
