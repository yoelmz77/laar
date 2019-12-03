using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblInservice")]
    public class Inservice
    {
        [Key]
        public int InserviceID { get; set; }
        public InserviceType InserviceType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Attachment { get; set; }
        public Staff SumittedBy { get; set; }
        public DateTime ApprovedUntil { get; set; }
        public Staff AprrovedBy { get; set; }

    }
}