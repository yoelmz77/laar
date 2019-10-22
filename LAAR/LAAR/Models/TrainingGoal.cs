using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblTrainingGoal")]
    public class TrainingGoal
    {
        [Key]
        public int TrainingGoalID { get; set; }
        public string Name { get; set; }
        public string Goal { get; set; } //DataCollection, Intervention, Replacement, UseOfReinforcement
        public string Type { get; set; } //Short, Long
        public ProgramType ProgramType { get; set; } //Maladaptive Behavior, Intervention, Replacement
        public int Amount { get; set; }
        public string Frequency { get; set; } //1w
        public string Duration { get; set; } //3m, 1m   
    }
}