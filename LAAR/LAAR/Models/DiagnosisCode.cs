using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblDiagnosisCode")]
    public class DiagnosisCode
    {
        [Key]
        public int DiagnosisCodeID { get; set; }
        public int Name { get; set; }
    }
}