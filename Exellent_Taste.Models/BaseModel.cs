using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exellent_Taste.Models
{
    public class BaseModel
    {
        [Key]
        public int ID { get; set; }

        public int? Created_Gebruiker_Id { get; set; }
        public int? Updated_Gebruiker_Id { get; set; }

        public DateTime? Created_Datum { get; set; }
        public DateTime? Updated_Datum { get; set; }

    }
}
