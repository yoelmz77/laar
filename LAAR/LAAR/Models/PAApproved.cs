using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblPAApproved")] //change to PAApproved
    public class PAApproved
    {
        [Key]
        public int PAApprovedID { get; set; }
        public int PANumber { get; set; }
        public DateTime PeriodStartDate { get; set; }
        public DateTime PeriodEndDate { get; set; }
        public int UnitsH2019 { get; set; }
        public int UnitsH2012 { get; set; }
        public int UnitsH2014 { get; set; }
    }
}