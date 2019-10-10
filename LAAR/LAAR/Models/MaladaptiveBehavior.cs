using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblMaladaptiveBehavior")]
    public class MaladaptiveBehavior
    {
        [Key]
        public int MaladaptiveBehaviorID { get; set; }
        public int Name { get; set; }
        public string UnitOfMeasurement { get; set; } //Incidents, Oportunities
        public DateTime CollectedFrom { get; set; }
        public DateTime CollectedTo { get; set; }
        public int Amount { get; set; } 
        public string Duration { get; set; } //1w
        public List<Objective> Outcomes { get; set; } //STOs & LTOs
    }

}