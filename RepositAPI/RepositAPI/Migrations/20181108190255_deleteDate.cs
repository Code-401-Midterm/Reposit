using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class deleteDate : Migration
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
                columns: new[] { "ID", "AuthorID", "CodeBody", "Language", "Notes", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Console.WriteLine(\"Hello World!\")", 8, "This is cool.", "Hello World console writeline" },
                    { 6, 1, @"
                def bubbleUp(arr):
                    swapped = True
                    while swapped == True:
                        swapped = False
                        i = 0
                        for i in range(len(arr) - 1):
                            if arr[i] > arr[i+1]:
                                arr[i],arr[i+1] = arr[i+1],arr[i]
                                swapped = True
                    print arr


                y = [4,3,1,5,-10,0]
                bubbleUp(y)

                def bubbleDown(arr):
                    swapped = True
                    while swapped == True:
                        swapped = False
                        i = len(arr) - 1
                        while i > 0:
                            if arr[i] < arr[i-1]:
                                arr[i],arr[i-1] = arr[i-1],arr[i]
                                swapped = True

                            i -= 1

                    print arr


                x = [4,3,1,5,0,10,-4,3,9,0,-20]
                bubbleDown(x)", 4, "Really old bubble sort in python. Does it even work?", "Bubblesort" },
                    { 9, 1, @"
                const newPatient = (req, res) => {
                    let SQL = 'INSERT INTO patients (first_name, last_name) VALUES ($1,$2) ON CONFLICT DO NOTHING RETURNING id';
                    let values = [req.body.first_name, req.body.last_name];
                    client.query(SQL, values, (err, serverRes) => {
                        if(err){
                            console.log(values);
                            console.error(err);
                            res.render('pages/error', {message: err});
                        }else{
                            res.redirect(`/patient/${serverRes.rows[0].id}?added=true`);
                        }
                    });
                };", 0, "Using sql with javascript. sample call", "Superagent" },
                    { 2, 2, "Print(\"Hello World!\")", 4, "This is cooler", "Hello World python" },
                    { 7, 2, @"
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
                }", 2, "Email algorithm using java", "Finding unique emails given email rules" },
                    { 5, 3, @"
                const mapTwoToThe = (input) => 
                {
                    return input.map(num => 2**num);
                }", 0, "Use array map method to take in an array and return a modified array. The returned array should containing the result of raising 2 to the power of the original input element.", "Array.Prototype.Map()" },
                    { 10, 3, "SELECT * FROM myTable", 11, "Simple sql query. * means everything!", "SQL" },
                    { 4, 4, @"
                public static int BinarySearchArray(int[] arr, int val)
                {
                    int start = 0;
                    int end = arr.Length - 1;
                    int mid;
                    while (start <= end)
                    {
                        mid = (start + end) / 2;
                        if (arr[mid] == val)
                        {
                            return mid;
                        }
                        else if (arr[mid] < val)
                        {
                            start = mid + 1;
                        }
                        else if (arr[mid] > val)
                        {
                            end = mid - 1;
                        }
                    }
                    return -1;
                }", 8, "Standard binary search on a sorted array.", "Binary search" },
                    { 3, 5, @"
                public class Node
                {
                    public object Value { get; set; }
                    public Node Right { get; set; }
                    public Node Left { get; set; }

                    public Node(object value)
                    {
                        Value = value;
                    }
                }", 8, "Basic Node class with a value and .Next property.", "Node" },
                    { 8, 5, @"
                <form>
                    First name:< br >
                    < input type = ""text"" name = ""firstname"" value = ""Mickey"" >
                    < br >
                    Last name:< br >
                    < input type = ""text"" name = ""lastname"" value = ""Mouse"" >
                    < br >< br >
                    < input type = ""submit"" value = ""Submit"" >
                </ form > ", 9, "Simple HTML form from w3schools", "Html form" }
                });

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
