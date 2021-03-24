using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyTreeBuilder.Migrations
{
    public partial class ExcludingDataOwnerIdFromPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data_owner_id",
                table: "person");

            migrationBuilder.RenameColumn(
                name: "sexo",
                table: "person",
                newName: "sex");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sex",
                table: "person",
                newName: "sexo");

            migrationBuilder.AddColumn<int>(
                name: "data_owner_id",
                table: "person",
                type: "integer",
                nullable: true);
        }
    }
}
