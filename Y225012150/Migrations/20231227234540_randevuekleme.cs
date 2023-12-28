using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Y225012150.Migrations
{
    /// <inheritdoc />
    public partial class randevuekleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Randevu",
                columns: table => new
                {
                    RandevuId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RandevuIl = table.Column<string>(type: "text", nullable: false),
                    RandevuIlce = table.Column<string>(type: "text", nullable: false),
                    RandevuKlinik = table.Column<string>(type: "text", nullable: false),
                    RandevuHastane = table.Column<string>(type: "text", nullable: false),
                    RandevuMuayeneYeri = table.Column<string>(type: "text", nullable: false),
                    RandevuHekim = table.Column<string>(type: "text", nullable: false),
                    RandevuTarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu", x => x.RandevuId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevu");
        }
    }
}
