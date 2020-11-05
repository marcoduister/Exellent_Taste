using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exellent_Taste.Models
{
    public class Bestellingen : BaseModel
    {
        public int Tafel { get; set; }
        public decimal Totaal { get; set; }

        public virtual ICollection<Bestellingen_Lijst> Bestellingen_Lijst { get; set; }
        public virtual ICollection<Reseveringen> Reseveringen { get; set; }
    }
}
