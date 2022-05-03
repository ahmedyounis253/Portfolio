using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_Studies_studyId",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Studies_studyId",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Studies_studyId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Profiles_profileId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Profiles_profileId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_studyId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "studyId",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "profileId",
                table: "Studies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "profileId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "profileId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "studyId",
                table: "Faculties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "studyId",
                table: "Certifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Studies_profileId",
                table: "Studies",
                column: "profileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_Studies_studyId",
                table: "Certifications",
                column: "studyId",
                principalTable: "Studies",
                principalColumn: "studyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Studies_studyId",
                table: "Faculties",
                column: "studyId",
                principalTable: "Studies",
                principalColumn: "studyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Profiles_profileId",
                table: "Projects",
                column: "profileId",
                principalTable: "Profiles",
                principalColumn: "profileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Profiles_profileId",
                table: "Skills",
                column: "profileId",
                principalTable: "Profiles",
                principalColumn: "profileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Studies_Profiles_profileId",
                table: "Studies",
                column: "profileId",
                principalTable: "Profiles",
                principalColumn: "profileId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_Studies_studyId",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Studies_studyId",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Profiles_profileId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Profiles_profileId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Studies_Profiles_profileId",
                table: "Studies");

            migrationBuilder.DropIndex(
                name: "IX_Studies_profileId",
                table: "Studies");

            migrationBuilder.DropColumn(
                name: "profileId",
                table: "Studies");

            migrationBuilder.AlterColumn<int>(
                name: "profileId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "profileId",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "studyId",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "studyId",
                table: "Faculties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "studyId",
                table: "Certifications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_studyId",
                table: "Profiles",
                column: "studyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_Studies_studyId",
                table: "Certifications",
                column: "studyId",
                principalTable: "Studies",
                principalColumn: "studyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Studies_studyId",
                table: "Faculties",
                column: "studyId",
                principalTable: "Studies",
                principalColumn: "studyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Studies_studyId",
                table: "Profiles",
                column: "studyId",
                principalTable: "Studies",
                principalColumn: "studyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Profiles_profileId",
                table: "Projects",
                column: "profileId",
                principalTable: "Profiles",
                principalColumn: "profileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Profiles_profileId",
                table: "Skills",
                column: "profileId",
                principalTable: "Profiles",
                principalColumn: "profileId");
        }
    }
}
