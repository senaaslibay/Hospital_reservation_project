using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y225012150.Migrations
{
    /// <inheritdoc />
    public partial class duzeltmeler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Randevu",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Randevu");
        }
    }
}
