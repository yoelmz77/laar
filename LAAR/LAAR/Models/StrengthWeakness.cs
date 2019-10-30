using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblStrengthWeakness")]
    public class StrengthWeakness
    {
        [Key]
        public int StrengthWeaknessID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } //Strenght Weakness
        public string Description { get; set; }
    }
}