using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblIntervention")]
    public class Intervention
    {
        [Key]
        public int InterventionID { get; set; }
        public int Name { get; set; }
    }
}