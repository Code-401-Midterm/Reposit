using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class changeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnippetTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Snippets",
                newName: "DateCreated");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Snippets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Snippets_AuthorID",
                table: "Snippets",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Snippets_Authors_AuthorID",
                table: "Snippets",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Snippets_Authors_AuthorID",
                table: "Snippets");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Snippets_AuthorID",
                table: "Snippets");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Snippets");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Snippets",
                newName: "date");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SnippetTags",
                columns: table => new
                {
                    SnippetID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnippetTags", x => new { x.SnippetID, x.TagID });
                    table.ForeignKey(
                        name: "FK_SnippetTags_Snippets_SnippetID",
                        column: x => x.SnippetID,
                        principalTable: "Snippets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SnippetTags_Tags_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SnippetTags_TagID",
                table: "SnippetTags",
                column: "TagID");
        }
    }
}
