using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblPARequest")]
    public class PARequest
    {
        [Key]
        public int PARequestID { get; set; }
        public DateTime PeriodStartDate { get; set; }
        public DateTime PeriodEndDate { get; set; }
        public int UnitsH2019 { get; set; }
        public int UnitsH2012 { get; set; }
        public int UnitsH2014 { get; set; }
    }
}