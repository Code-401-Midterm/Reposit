using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositAPI.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 287, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"
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
}", new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"
const mapTwoToThe = (input) => 
{
    return input.map(num => 2**num);
}", new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"
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
bubbleDown(x)", new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"
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
}", new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"
<form>
    First name:< br >
    < input type = ""text"" name = ""firstname"" value = ""Mickey"" >
    < br >
    Last name:< br >
    < input type = ""text"" name = ""lastname"" value = ""Mouse"" >
    < br >< br >
    < input type = ""submit"" value = ""Submit"" >
</ form > ", new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 33, 20, 815, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"public static int BinarySearchArray(int[] arr, int val)
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
                                }", new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"const mapTwoToThe = (input) => 
                               {
                                   return input.map(num => 2**num);
                               }", new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"def bubbleUp(arr):
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
                                bubbleDown(x)", new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"public int numUniqueEmails(String[] emails) {
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
                            }", new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"<form>
                                  First name:< br >
                                  < input type = ""text"" name = ""firstname"" value = ""Mickey"" >
                                  < br >
                                  Last name:< br >
                                  < input type = ""text"" name = ""lastname"" value = ""Mouse"" >
                                  < br >< br >
                                  < input type = ""submit"" value = ""Submit"" >
                                </ form > ", new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 33, 20, 817, DateTimeKind.Local));
        }
    }
}
