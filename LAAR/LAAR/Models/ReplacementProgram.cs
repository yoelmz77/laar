using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblReplacementProgram")]
    public class ReplacementProgram
    {
        [Key]
        public int ReplacementProgramID { get; set; }
        public int Name { get; set; }
    }
}