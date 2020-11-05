using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exellent_Taste.Models
{
    public class Menusoort :BaseModel
    {
        public string Naam { get; set; }

        public int? MenuSoortID { get; set; }
        public virtual Menusoort menusoort { get; set; }

        public virtual ICollection<Menukaart> Menukaarts { get; set; }

    }
}
