using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblProgram")]
    public class Program
    {
        [Key]
        public int ProgramID { get; set; }
        public string Description { get; set; } 
        public ProgramType ProgramType { get; set; }
        public DateTime CollectedFrom { get; set; }
        public DateTime CollectedTo { get; set; }
        public int Amount { get; set; }
        public string Duration { get; set; } //1w
        public List<Objective> Objectives { get; set; } //STOs & LTOs }
    }
}