using Microsoft.EntityFrameworkCore.Migrations;

namespace Exellent_Taste.DAL.Migrations
{
    public partial class addgeleverd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Geleverd",
                table: "Bestellingen_Lijst",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Geleverd",
                table: "Bestellingen_Lijst");
        }
    }
}
