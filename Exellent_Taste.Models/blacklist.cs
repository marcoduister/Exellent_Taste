using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exellent_Taste.Models
{
    public class BlackList : BaseModel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public int Resevering_id { get; set; }
        public virtual Reseveringen reseveringen { get; set; }
    }
}
