using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y225012150.Migrations
{
    /// <inheritdoc />
    public partial class roluseratamaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Roller_UserRollerRollerID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserRollerRollerID",
                table: "AspNetUsers",
                newName: "RollerID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserRollerRollerID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_RollerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Roller_RollerID",
                table: "AspNetUsers",
                column: "RollerID",
                principalTable: "Roller",
                principalColumn: "RollerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Roller_RollerID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "RollerID",
                table: "AspNetUsers",
                newName: "UserRollerRollerID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_RollerID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserRollerRollerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Roller_UserRollerRollerID",
                table: "AspNetUsers",
                column: "UserRollerRollerID",
                principalTable: "Roller",
                principalColumn: "RollerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
