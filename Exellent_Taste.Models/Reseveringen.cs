using System;
using System.ComponentModel.DataAnnotations;

namespace Exellent_Taste.Models
{
    public class Reseveringen : BaseModel
    {
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telefoonnummer { get; set; }
        public int Tafel { get; set; }
        [Required]
        public int Aantal_Personen { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public string Tijd { get; set; }
        public Boolean Gekomen { get; set; }
        public int? Bestelling_id { get; set; }
        public virtual Bestellingen Bestellingen { get; set; }

        public int Adress_id { get; set; }
        public virtual Adress Adress { get; set; }
    }
}
