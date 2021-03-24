using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyTreeBuilder.Migrations
{
    public partial class SeedPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "person",
                columns: new[] { "id", "birth_date", "death_date", "father", "first_name", "last_name", "mother", "sex" },
                values: new object[,]
                {
                    { 1, new DateTime(1950, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hommer", "Simpson", null, null },
                    { 2, new DateTime(1955, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Marge", "Simpson", null, null },
                    { 3, new DateTime(1970, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bart", "Simpson", null, null },
                    { 4, new DateTime(1980, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lisa", "Simpson", null, null },
                    { 5, new DateTime(1987, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maggie", "Simpson", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "person",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "person",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "person",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "person",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "person",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
