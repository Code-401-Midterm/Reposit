using System;
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
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 100, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"
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
};", new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 49, 17, 101, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CodeBody", "Date" },
                values: new object[] { @"const newPatient = (req, res) => {
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
                                };", new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Snippets",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2018, 11, 7, 16, 44, 37, 290, DateTimeKind.Local));
        }
    }
}
