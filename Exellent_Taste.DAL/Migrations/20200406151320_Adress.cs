using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exellent_Taste.DAL.Migrations
{
    public partial class Adress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Adress_id",
                table: "Reseveringen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Straat = table.Column<string>(nullable: true),
                    Huisnummer = table.Column<string>(nullable: true),
                    Toevoeging = table.Column<string>(nullable: true),
                    Stad = table.Column<string>(nullable: true),
                    Land = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reseveringen_Adress_id",
                table: "Reseveringen",
                column: "Adress_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reseveringen_Adress_Adress_id",
                table: "Reseveringen",
                column: "Adress_id",
                principalTable: "Adress",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reseveringen_Adress_Adress_id",
                table: "Reseveringen");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropIndex(
                name: "IX_Reseveringen_Adress_id",
                table: "Reseveringen");

            migrationBuilder.DropColumn(
                name: "Adress_id",
                table: "Reseveringen");
        }
    }
}
