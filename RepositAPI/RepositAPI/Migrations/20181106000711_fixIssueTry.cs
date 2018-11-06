using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class fixIssueTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Snippets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodeBody = table.Column<string>(nullable: false),
                    Language = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    AuthorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snippets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Snippets_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                values: new object[] { 1, 1, "Console.WriteLine(\"Hello World!\")", new DateTime(2018, 11, 5, 16, 7, 11, 641, DateTimeKind.Local), 8, "This is cool.", "Hello World console writeline" });

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "ID", "AuthorID", "CodeBody", "DateCreated", "Language", "Notes", "Title" },
                values: new object[] { 2, 2, "Print(\"Hello World!\")", new DateTime(2018, 11, 5, 16, 7, 11, 643, DateTimeKind.Local), 4, "This is cooler", "Hello World python" });

            migrationBuilder.CreateIndex(
                name: "IX_Snippets_AuthorID",
                table: "Snippets",
                column: "AuthorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Snippets");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
