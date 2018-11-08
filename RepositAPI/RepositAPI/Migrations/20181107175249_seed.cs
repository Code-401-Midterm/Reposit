using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Snippets",
                columns: new[] { "ID", "AuthorID", "CodeBody", "Date", "Language", "Notes", "Title" },
                values: new object[,]
                {
                    { 3, 5, @"public class Node
                                                {
                                                    public object Value { get; set; }
                                                    public Node Right { get; set; }
                                                    public Node Left { get; set; }

                                                    public Node(object value)
                                                    {
                                                        Value = value;
                                                    }
                                                }", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 8, "Basic Node class with a value and .Next property.", "Node" },
                    { 4, 4, @"public static int BinarySearchArray(int[] arr, int val)
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
                                                }", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 8, "Standard binary search on a sorted array.", "Binary search" },
                    { 5, 3, @"const mapTwoToThe = (input) => 
                                               {
                                                   return input.map(num => 2**num);
                                               }", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 0, "Use array map method to take in an array and return a modified array. The returned array should containing the result of raising 2 to the power of the original input element.", "Array.Prototype.Map()" },
                    { 6, 1, @"def bubbleUp(arr):
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
                                                bubbleDown(x)", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 4, "Really old bubble sort in python. Does it even work?", "" },
                    { 7, 2, @"public int numUniqueEmails(String[] emails) {
                                                   Set<String> seen = new HashSet();
                                                   for (String email: emails) {
                                                       int i = email.indexOf('@');
                                                       String local = email.substring(0, i);
                                                       String rest = email.substring(i);
                                                       if (local.contains(""+"")) {
                                                           local = local.substring(0, local.indexOf('+'));
                                                    }
                                                    local = local.replaceAll(""."", "");
                                                       seen.add(local + rest);
                                                   }

                                                   return seen.size();
                                               }
                                            }", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 2, "Email algorithm using java", "Finding unique emails given email rules" },
                    { 8, 5, @"<form>
                                                  First name:< br >
                                                  < input type = ""text"" name = ""firstname"" value = ""Mickey"" >
                                                  < br >
                                                  Last name:< br >
                                                  < input type = ""text"" name = ""lastname"" value = ""Mouse"" >
                                                  < br >< br >
                                                  < input type = ""submit"" value = ""Submit"" >
                                                </ form > ", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 9, "Simple HTML form from w3schools", "Html form" },
                    { 9, 1, @"const newPatient = (req, res) => {
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
                                                };", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 0, "Using sql with javascript. sample call", "Superagent" },
                    { 10, 3, "SELECT * FROM myTable", new DateTime(2018, 11, 7, 9, 52, 48, 762, DateTimeKind.Local), 11, "Simple sql query. * means everything!", "SQL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2018, 11, 6, 13, 1, 0, 506, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 6, 13, 1, 0, 508, DateTimeKind.Local));
        }
    }
}
