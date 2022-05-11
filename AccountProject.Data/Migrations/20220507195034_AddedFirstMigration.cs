using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountProject.Data.Migrations
{
    public partial class AddedFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarifeBirimId = table.Column<int>(nullable: false),
                    KdvOranId = table.Column<int>(nullable: false),
                    TarifeBirimFiyat = table.Column<decimal>(type: "decimal(5,3)", maxLength: 50, nullable: false),
                    İlkEndeks = table.Column<decimal>(type: "decimal(5,3)", maxLength: 200, nullable: false),
                    SonEndeks = table.Column<decimal>(type: "decimal(5,3)", maxLength: 250, nullable: false),
                    HesapTarihi = table.Column<DateTime>(nullable: false),
                    TarifeKdvFiyat = table.Column<decimal>(type: "decimal(5,3)", maxLength: 100, nullable: false),
                    TarifeToplamFiyat = table.Column<decimal>(type: "decimal(5,3)", maxLength: 150, nullable: false),
                    HesaplamaTürü = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
