using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Giris2.Migrations
{
    public partial class UserAddGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderID1",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_GenderID1",
                table: "User",
                column: "GenderID1");

            migrationBuilder.AddForeignKey(
                name: "FK_User_genders_GenderID1",
                table: "User",
                column: "GenderID1",
                principalTable: "genders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_genders_GenderID1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_GenderID1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GenderID1",
                table: "User");
        }
    }
}
