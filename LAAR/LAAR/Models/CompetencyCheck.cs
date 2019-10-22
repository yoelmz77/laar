using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblCompetencyCheck")]
    public class CompetencyCheck
    {
        [Key]
        public int CompetencyCheckID { get; set; }
        public CompetencyCheckType CompetencyCheckType { get; set; }
        public Client Client { get; set; }
        public Staff Staff { get; set; }
        public string LengthofObservation { get; set; } //m,w,d
        public string DataCollection { get; set; } //Store as JSON
        public string Interventions { get; set; } //Store as JSON
        public string Replacements { get; set; } //Store as JSON
        public string Reinforcements { get; set; } //Store as JSON
        public DateTime Date { get; set; }
        public DateTime SignatureDate { get; set; }

    }
}