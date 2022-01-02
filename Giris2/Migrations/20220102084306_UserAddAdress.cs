using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Giris2.Migrations
{
    public partial class UserAddAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_genders_GenderID1",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genders",
                table: "genders");

            migrationBuilder.RenameTable(
                name: "genders",
                newName: "Gender");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Adres_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adres_UserID",
                table: "Adres",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Gender_GenderID1",
                table: "User",
                column: "GenderID1",
                principalTable: "Gender",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Gender_GenderID1",
                table: "User");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "genders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genders",
                table: "genders",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_genders_GenderID1",
                table: "User",
                column: "GenderID1",
                principalTable: "genders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
