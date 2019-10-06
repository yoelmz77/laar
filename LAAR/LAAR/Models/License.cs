using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblLicense")]
    public class License
    {
        [Key]
        public int LicenseID { get; set; }
        public LicenseType LicenseType { get; set; }
        public DateTime Expires { get; set; }
        public Staff SumittedBy { get; set; }
        public Staff AprrovedBy { get; set; }
        public string Attachement { get; set; }

    }
}