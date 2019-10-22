using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblCompetencyCheckType")]
    public class CompetencyCheckType
    {
        [Key]
        public int CompetencyCheckTypeID { get; set; }
        public string name { get; set; } //Caregiver, RBT
    }
}