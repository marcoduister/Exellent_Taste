using Exellent_Taste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exellent_Taste.DAL
{
    public class Seed
    {
        public static void Initialize(ExellentDbContext context)
        {
            if (!context.Gebruikers.Any())
            {
                var gebruikers = new List<Gebruikers>()
                {
                new Gebruikers { /*ID = 1,*/ Voornaam = "marco", Achternaam ="Duister", Wachtwoord ="Qwerty1", Email = "marco@Newapps.be",Created_Datum = DateTime.Now, Created_Gebruiker_Id = 0, Updated_Datum = DateTime.Now , Updated_Gebruiker_Id = 0 },
                new Gebruikers { /*ID = 2,*/ Voornaam = "Dave", Achternaam ="van boven",Wachtwoord ="Qwerty1", Email = "Dave@Newapps.be",Created_Datum = DateTime.Now, Created_Gebruiker_Id = 0, Updated_Datum = DateTime.Now, Updated_Gebruiker_Id = 0 }
                };
                 context.Gebruikers.AddRange(gebruikers);
                 context.SaveChanges();
            }
            if (!context.Menusoort.Any())
            {
                var menusoort = new List<Menusoort>()
                {
                #region drank
                new Menusoort { /*ID = 1*/ Naam ="Drank", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 2,*/ Naam = "Dranken", MenuSoortID =18, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 3,*/ Naam = "hapjes", MenuSoortID =18, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 4,*/ Naam ="Warmedranken",MenuSoortID =1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 5,*/ Naam = "Bieren", MenuSoortID =1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 6,*/ Naam = "Huiswijnen", MenuSoortID =1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 7,*/ Naam ="Frisdranken", MenuSoortID =1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 8,*/ Naam = "Warmehapjes", MenuSoortID =17, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 9,*/ Naam = "Koudehapjes", MenuSoortID =17, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
	            #endregion
                #region gerechten
                new Menusoort { /*ID = 10,*/ Naam ="gerechten", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 12,*/ Naam = "voorgerechten", MenuSoortID =10, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 13,*/ Naam = "hoofdgerechten", MenuSoortID =10, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 14,*/ Naam ="Nagerechten", MenuSoortID =10, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 15,*/ Naam = "warme voorgerechten", MenuSoortID =9, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 16,*/ Naam = "Koude voorgerechten", MenuSoortID =9, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 17,*/ Naam ="vis gerechten", MenuSoortID =8, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 18,*/ Naam = "vlees gerechten", MenuSoortID =8, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 19,*/ Naam = "vegetarische gerechten", MenuSoortID =8, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 20,*/ Naam = "Ijs", MenuSoortID =7, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menusoort { /*ID = 20,*/ Naam = "Mousse", MenuSoortID =7, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                #endregion

                };
                context.Menusoort.AddRange(menusoort);
                context.SaveChanges();
            }
            if (!context.Menukaart.Any())
            {
                var menukaart = new List<Menukaart>()
                {
                //voorgerechten
                new Menukaart { /*ID = 1,*/ Naam ="Bitterballenmetmosterd", MenuSoort_id = 6, Prijs = 4.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Groentesoep", MenuSoort_id = 6, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 3,*/ Naam ="Aspergesoep",MenuSoort_id = 6, Prijs = 4.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 1,*/ Naam ="Uiensoep", MenuSoort_id = 6, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Salademetgeitenkaas",MenuSoort_id = 5, Prijs = 4.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 3,*/ Naam ="Tonijnsalade",MenuSoort_id = 5, Prijs = 5.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 1,*/ Naam ="Zalmsalade", MenuSoort_id = 5, Prijs = 5.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                //hoofdgerechten
                new Menukaart { /*ID = 2,*/ Naam ="Gebakkenmakreel", MenuSoort_id = 4, Prijs = 8.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 3,*/ Naam ="Mosselenuitpan",MenuSoort_id = 4, Prijs = 9.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 1,*/ Naam ="Biefstukinchampignonsaus",MenuSoort_id = 3, Prijs = 11.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Wienerschnitzel",MenuSoort_id = 3, Prijs = 9.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 3,*/ Naam ="Bonengerechtmetdiversegroente",MenuSoort_id = 2, Prijs = 11.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 1,*/ Naam ="Gebakkenbanaan",MenuSoort_id = 2, Prijs = 10.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                
                //nagerechten
                new Menukaart { /*ID = 2,*/ Naam ="BlackLady", MenuSoort_id = 19, Prijs = 4.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 3,*/ Naam ="Vruchtenijs",MenuSoort_id = 19, Prijs = 2.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 1,*/ Naam ="Chocolademousse", MenuSoort_id = 20, Prijs = 4.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Vanillemousse", MenuSoort_id = 20, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },

                // warme
                new Menukaart { /*ID = 2,*/ Naam ="Koffie", MenuSoort_id = 16, Prijs = 2.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 3,*/ Naam ="Thee",MenuSoort_id = 16, Prijs = 2.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 1,*/ Naam ="Chocolademelk", MenuSoort_id = 16, Prijs = 2.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Espresso", MenuSoort_id = 16, Prijs = 2.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 3,*/ Naam ="Cappuccino",MenuSoort_id = 16, Prijs = 2.75m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 1,*/ Naam ="Koffieverkeerd", MenuSoort_id = 16, Prijs = 2.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Lattemacchiato", MenuSoort_id = 16, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },

                //bieren
                new Menukaart { /*ID = 2,*/ Naam ="Pilsner", MenuSoort_id = 15, Prijs = 2.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Weizen", MenuSoort_id = 15, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Stender", MenuSoort_id = 15, Prijs = 2.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Palm", MenuSoort_id = 15, Prijs = 3.60m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Kasteeldonker", MenuSoort_id = 15, Prijs = 4.75m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Brugsezot", MenuSoort_id = 15, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Grimbergendubbe", MenuSoort_id = 15, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                //huiswijnen
                new Menukaart { /*ID = 2,*/ Naam ="Perglas", MenuSoort_id = 14, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Per fles", MenuSoort_id = 14, Prijs = 17.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Seizoenswijn", MenuSoort_id = 14, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Rodepor", MenuSoort_id = 14, Prijs = 3.60m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                
                //frisdranken
                new Menukaart { /*ID = 2,*/ Naam ="Tonic", MenuSoort_id = 13, Prijs = 2.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="SevenUp", MenuSoort_id = 13, Prijs = 2.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="VerseJus", MenuSoort_id = 13, Prijs = 3.95m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Chaudfontainerood", MenuSoort_id = 13, Prijs = 2.75m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Chaudfontaineblauw", MenuSoort_id = 13, Prijs = 2.75m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                
                //warme hapjes
                new Menukaart { /*ID = 2,*/ Naam ="Bitterballenmetmosterd", MenuSoort_id = 12, Prijs = 4.00m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Vlammetjesmetchilisaus", MenuSoort_id = 12, Prijs = 4.00m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Kipbites", MenuSoort_id = 12, Prijs = 5.00m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                
                //koude hapjes
                new Menukaart { /*ID = 2,*/ Naam ="Portiekaasmetmosterd", MenuSoort_id = 11, Prijs = 4.00m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Broodmetkruidenbote", MenuSoort_id = 11, Prijs = 5.00m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Menukaart { /*ID = 2,*/ Naam ="Portiesalamiworst", MenuSoort_id = 11, Prijs = 4.00m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },

                };
                context.Menukaart.AddRange(menukaart);
                context.SaveChanges();
            }
            if (!context.Bestellingen.Any())
            {
                var bestellingen = new List<Bestellingen>()
                {
                new Bestellingen { /*ID = 1,*/ Tafel = 1 ,Totaal = 29.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen { /*ID = 2,*/ Tafel = 3 ,Totaal = 29.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen { /*ID = 3,*/ Tafel = 2 ,Totaal = 29.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen { /*ID = 4,*/ Tafel = 1 ,Totaal = 29.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen { /*ID = 5,*/ Tafel = 5 ,Totaal = 29.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen { /*ID = 6,*/ Tafel = 4 ,Totaal = 29.45m, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },

                };
                context.Bestellingen.AddRange(bestellingen);
                context.SaveChanges();
            }
            if (!context.Adress.Any())
            {
                var adress = new List<Adress>()
                {
                new Adress { /*ID = 1,*/ Straat ="kerkstraat",Huisnummer ="1",Toevoeging="",Stad= "maastricht",Land="NL",Postcode="6466rt" , Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Adress { /*ID = 2,*/ Straat ="kerkstraat",Huisnummer ="2",Toevoeging="",Stad= "maastricht",Land="NL",Postcode="6466rt" , Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Adress { /*ID = 3,*/ Straat ="kerkstraat",Huisnummer ="3",Toevoeging="",Stad= "maastricht",Land="NL",Postcode="6466rt" , Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Adress { /*ID = 4,*/ Straat ="kerkstraat",Huisnummer ="4",Toevoeging="",Stad= "maastricht",Land="NL",Postcode="6466rt" , Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Adress { /*ID = 5,*/ Straat ="kerkstraat",Huisnummer ="5",Toevoeging="",Stad= "maastricht",Land="NL",Postcode="6466rt" , Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Adress { /*ID = 6,*/ Straat ="kerkstraat",Huisnummer ="6",Toevoeging="",Stad= "maastricht",Land="NL",Postcode="6466rt" , Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },

                };
                context.Adress.AddRange(adress);
                context.SaveChanges();
            }
            if (!context.Reseveringen.Any())
            {
                var reseveringen = new List<Reseveringen>()
                {
                new Reseveringen { /*ID = 1,*/  Bestelling_id=1, Adress_id =1, Tafel=1, Voornaam = "Jansen",Achternaam ="", Email = "marco@Newapps.be", Aantal_Personen = 5, Tijd="18:00", Datum = new DateTime(2020, 4, 17), Gekomen = false, Telefoonnummer ="0648824500", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Reseveringen { /*ID = 2,*/  Bestelling_id=2, Adress_id =2, Tafel=3, Voornaam = "Faoud",Achternaam ="van boven", Email = "Dave@Newapps.be", Aantal_Personen = 5, Tijd="19:00", Datum = new DateTime(2020, 4, 17), Gekomen = false, Telefoonnummer ="0648824500", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Reseveringen { /*ID = 3,*/  Bestelling_id=3, Adress_id =3, Tafel=2, Voornaam = "Mevrouw Pietersen",Achternaam ="Duister", Email = "marco@Newapps.be", Aantal_Personen = 5, Tijd="18:00", Datum = new DateTime(2020, 4, 17), Gekomen = false, Telefoonnummer ="0648824500", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Reseveringen { /*ID = 4,*/  Bestelling_id=4, Adress_id =4, Tafel=1, Voornaam = "",Achternaam ="Van den Ouden", Email = "Dave@Newapps.be", Aantal_Personen = 5, Tijd="19:00", Datum = new DateTime(2020, 4, 17), Gekomen = false, Telefoonnummer ="0648824500", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Reseveringen { /*ID = 5,*/  Bestelling_id=5, Adress_id =5, Tafel=5, Voornaam = "Boodaart",Achternaam ="", Email = "marco@Newapps.be", Aantal_Personen = 5, Tijd="17:00", Datum = new DateTime(2020, 4, 17), Gekomen = false, Telefoonnummer ="0648824500", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Reseveringen { /*ID = 6,*/  Bestelling_id=6, Adress_id =6, Tafel=4, Voornaam = "j",Achternaam ="de la Guiterraz", Email = "Dave@Newapps.be", Aantal_Personen = 5, Tijd="18:00", Datum = new DateTime(2020, 4, 17), Gekomen = false, Telefoonnummer ="0648824500", Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 }

                };
                context.Reseveringen.AddRange(reseveringen);
                context.SaveChanges();
            }
            if (!context.Bestellingen_Lijst.Any())
            {
                var bestellingen_Lijst = new List<Bestellingen_Lijst>()
                {
                #region resevering 1
                new Bestellingen_Lijst { /*ID = 1,*/ Bestelling_Id = 1, MenuKaart_Id = 1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 2,*/ Bestelling_Id = 1, MenuKaart_Id = 4, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 3,*/ Bestelling_Id = 1, MenuKaart_Id = 31, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 4,*/ Bestelling_Id = 1, MenuKaart_Id = 35, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                #endregion
                #region resevering 2
                new Bestellingen_Lijst { /*ID = 1,*/ Bestelling_Id = 2, MenuKaart_Id = 1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 2,*/ Bestelling_Id = 2, MenuKaart_Id = 4, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 3,*/ Bestelling_Id = 2, MenuKaart_Id = 31, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 4,*/ Bestelling_Id = 2, MenuKaart_Id = 35, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                #endregion
                #region resevering 3
                new Bestellingen_Lijst { /*ID = 1,*/ Bestelling_Id = 3, MenuKaart_Id = 1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 2,*/ Bestelling_Id = 3, MenuKaart_Id = 4, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 3,*/ Bestelling_Id = 3, MenuKaart_Id = 31, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 4,*/ Bestelling_Id = 3, MenuKaart_Id = 35, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                #endregion
                #region resevering 4
                new Bestellingen_Lijst { /*ID = 1,*/ Bestelling_Id = 4, MenuKaart_Id = 1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 2,*/ Bestelling_Id = 4, MenuKaart_Id = 4, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 3,*/ Bestelling_Id = 4, MenuKaart_Id = 31, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 4,*/ Bestelling_Id = 4, MenuKaart_Id = 35, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                #endregion
                #region resevering 5
                new Bestellingen_Lijst { /*ID = 1,*/ Bestelling_Id = 5, MenuKaart_Id = 1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 2,*/ Bestelling_Id = 5, MenuKaart_Id = 4, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 3,*/ Bestelling_Id = 5, MenuKaart_Id = 31, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 4,*/ Bestelling_Id = 5, MenuKaart_Id = 35, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                #endregion
                #region resevering 6
                new Bestellingen_Lijst { /*ID = 1,*/ Bestelling_Id = 6, MenuKaart_Id = 1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 2,*/ Bestelling_Id = 6, MenuKaart_Id = 4, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 3,*/ Bestelling_Id = 6, MenuKaart_Id = 31, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new Bestellingen_Lijst { /*ID = 4,*/ Bestelling_Id = 6, MenuKaart_Id = 35, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                #endregion
                };
                context.Bestellingen_Lijst.AddRange(bestellingen_Lijst);
                context.SaveChanges();
            }

            if (!context.BlackList.Any())
            {
                var blacklist = new List<BlackList>()
                {
                new BlackList { /*ID = 1,*/ Voornaam = "marco", Achternaam ="Duister", Email = "marco@Newapps.be", Resevering_id = 1, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2 },
                new BlackList { /*ID = 2,*/ Voornaam = "Dave", Achternaam ="van boven", Email = "Dave@Newapps.be", Resevering_id = 2, Created_Datum = new DateTime(2020, 3, 30), Created_Gebruiker_Id = 1, Updated_Datum = new DateTime(2020, 3, 30), Updated_Gebruiker_Id = 2  }

                };
                context.BlackList.AddRange(blacklist);
                context.SaveChanges();
            }


        }
    }
}
