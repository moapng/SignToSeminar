using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SignToSeminarBackEnd.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Seminars",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    numberOfAvailableSeats = table.Column<int>(nullable: false),
                    UserModelid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminars", x => x.id);
                    table.ForeignKey(
                        name: "FK_Seminars_Users_UserModelid",
                        column: x => x.UserModelid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seminars_UserModelid",
                table: "Seminars",
                column: "UserModelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seminars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
