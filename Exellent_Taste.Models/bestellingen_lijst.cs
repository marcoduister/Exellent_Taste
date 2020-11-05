using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exellent_Taste.Models
{
    public class Bestellingen_Lijst : BaseModel
    {
        public int? Bestelling_Id { get; set; }
        public virtual Bestellingen bestellingen { get; set; }

        public int? MenuKaart_Id { get; set; }
        public virtual Menukaart menukaart { get; set; }

        public Boolean Geleverd { get; set; }

    }
}
