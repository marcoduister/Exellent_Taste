using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exellent_Taste.Models
{
    public class Adress : BaseModel
    {
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Toevoeging { get; set; }
        public string Stad { get; set; }
        public string Land { get; set; }
        public string Postcode { get; set; }
        public virtual ICollection<Reseveringen> Reseveringen { get; set; }
    }
}
