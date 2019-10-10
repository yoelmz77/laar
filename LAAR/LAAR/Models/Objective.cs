using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblObjective")]
    public class Objective
    {
        [Key]
        public int ObjectiveID { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; } //Short, Long
        public int AmountFrom { get; set; } 
        public int AmountTo { get; set; }
        public string Frequency { get; set; } //1w
        public string Duration { get; set; } //3m, 1m
    }
}