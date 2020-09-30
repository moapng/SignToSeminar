using Microsoft.EntityFrameworkCore.Migrations;

namespace SignToSeminarBackEnd.Migrations
{
    public partial class AddUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Seminars",
                table: "Seminars");

            migrationBuilder.RenameTable(
                name: "Seminars",
                newName: "SeminarModel");

            migrationBuilder.AddColumn<int>(
                name: "UserModelid",
                table: "SeminarModel",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeminarModel",
                table: "SeminarModel",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emailAdress = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeminarModel_UserModelid",
                table: "SeminarModel",
                column: "UserModelid");

            migrationBuilder.AddForeignKey(
                name: "FK_SeminarModel_Users_UserModelid",
                table: "SeminarModel",
                column: "UserModelid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeminarModel_Users_UserModelid",
                table: "SeminarModel");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeminarModel",
                table: "SeminarModel");

            migrationBuilder.DropIndex(
                name: "IX_SeminarModel_UserModelid",
                table: "SeminarModel");

            migrationBuilder.DropColumn(
                name: "UserModelid",
                table: "SeminarModel");

            migrationBuilder.RenameTable(
                name: "SeminarModel",
                newName: "Seminars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seminars",
                table: "Seminars",
                column: "id");
        }
    }
}
