using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exellent_Taste.Models
{
    public class Menukaart :BaseModel
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public decimal Prijs { get; set; }

        public int? MenuSoort_id { get; set; }
        public virtual Menusoort menusoort { get; set; }

        public virtual  ICollection<Bestellingen_Lijst> Bestellingen_Lijst { get; set; }
    }
}
