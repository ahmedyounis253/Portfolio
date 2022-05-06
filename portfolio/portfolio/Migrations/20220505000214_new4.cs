using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "preferedNmae",
                table: "Profiles",
                newName: "preferedName");

            migrationBuilder.AddColumn<bool>(
                name: "isVerified",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isVerified",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "preferedName",
                table: "Profiles",
                newName: "preferedNmae");
        }
    }
}
