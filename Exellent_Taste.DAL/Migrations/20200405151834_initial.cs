using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exellent_Taste.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bestellingen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Tafel = table.Column<int>(nullable: false),
                    Totaal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bestellingen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Wachtwoord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menusoort",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Naam = table.Column<string>(nullable: true),
                    MenuSoortID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menusoort", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menusoort_Menusoort_MenuSoortID",
                        column: x => x.MenuSoortID,
                        principalTable: "Menusoort",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reseveringen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Voornaam = table.Column<string>(nullable: false),
                    Achternaam = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefoonnummer = table.Column<string>(nullable: false),
                    Tafel = table.Column<int>(nullable: false),
                    Aantal_Personen = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Tijd = table.Column<string>(nullable: false),
                    Gekomen = table.Column<bool>(nullable: false),
                    Bestelling_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reseveringen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reseveringen_Bestellingen_Bestelling_id",
                        column: x => x.Bestelling_id,
                        principalTable: "Bestellingen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menukaart",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Naam = table.Column<string>(nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Prijs = table.Column<decimal>(nullable: false),
                    MenuSoort_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menukaart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menukaart_Menusoort_MenuSoort_id",
                        column: x => x.MenuSoort_id,
                        principalTable: "Menusoort",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlackList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Resevering_id = table.Column<int>(nullable: false),
                    reseveringenID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BlackList_Reseveringen_reseveringenID",
                        column: x => x.reseveringenID,
                        principalTable: "Reseveringen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bestellingen_Lijst",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Gebruiker_Id = table.Column<int>(nullable: true),
                    Updated_Gebruiker_Id = table.Column<int>(nullable: true),
                    Created_Datum = table.Column<DateTime>(nullable: true),
                    Updated_Datum = table.Column<DateTime>(nullable: true),
                    Bestelling_Id = table.Column<int>(nullable: true),
                    MenuKaart_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bestellingen_Lijst", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Lijst_Bestellingen_Bestelling_Id",
                        column: x => x.Bestelling_Id,
                        principalTable: "Bestellingen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Lijst_Menukaart_MenuKaart_Id",
                        column: x => x.MenuKaart_Id,
                        principalTable: "Menukaart",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_Lijst_Bestelling_Id",
                table: "Bestellingen_Lijst",
                column: "Bestelling_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_Lijst_MenuKaart_Id",
                table: "Bestellingen_Lijst",
                column: "MenuKaart_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BlackList_reseveringenID",
                table: "BlackList",
                column: "reseveringenID");

            migrationBuilder.CreateIndex(
                name: "IX_Menukaart_MenuSoort_id",
                table: "Menukaart",
                column: "MenuSoort_id");

            migrationBuilder.CreateIndex(
                name: "IX_Menusoort_MenuSoortID",
                table: "Menusoort",
                column: "MenuSoortID");

            migrationBuilder.CreateIndex(
                name: "IX_Reseveringen_Bestelling_id",
                table: "Reseveringen",
                column: "Bestelling_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bestellingen_Lijst");

            migrationBuilder.DropTable(
                name: "BlackList");

            migrationBuilder.DropTable(
                name: "Gebruikers");

            migrationBuilder.DropTable(
                name: "Menukaart");

            migrationBuilder.DropTable(
                name: "Reseveringen");

            migrationBuilder.DropTable(
                name: "Menusoort");

            migrationBuilder.DropTable(
                name: "Bestellingen");
        }
    }
}
