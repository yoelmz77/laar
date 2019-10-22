using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblABCReport")]
    public class ABCReport
    {
        [Key]
        public int ABCReportID { get; set; }
        public string Antecedent { get; set; }
        public string Behavior { get; set; }
        public string Consequence { get; set; }
    }
}