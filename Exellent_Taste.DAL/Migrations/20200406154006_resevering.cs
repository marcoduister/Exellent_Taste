using Microsoft.EntityFrameworkCore.Migrations;

namespace Exellent_Taste.DAL.Migrations
{
    public partial class resevering : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Bestelling_id",
                table: "Reseveringen",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Bestelling_id",
                table: "Reseveringen",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
