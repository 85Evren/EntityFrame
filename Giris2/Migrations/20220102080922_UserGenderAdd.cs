using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Giris2.Migrations
{
    public partial class UserGenderAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GenderID",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "User");
        }
    }
}
