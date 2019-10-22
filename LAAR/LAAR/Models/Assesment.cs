using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblAssesment")]
    public class Assesment
    {
        [Key]
        public int AssesmentID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } //Initial, Reassesment
        public Client Client { get; set; } // Recepient
        public Staff Staff { get; set; } // Evaluator
        public string BackgroundInformation { get; set; }
        public List<Medication> Medications { get; set; }
        public List<Observation> Observations { get; set; }
        public List<ABCReport> ABCReports { get; set; }
        public List<StrengthWeakness> StrengthsAndWeakness { get; set; }
        public List<Program> MaladaptiveBehaviors { get; set; }
        public List<Program> Interventions { get; set; }
        public List<Program> ReplacementPrograms { get; set; }
        public List<BehaviorService> BehaviorServices { get; set; }
        public string CaregiverInvolvement { get; set; }
        public List<TrainingGoal> CaregiverDataCollection { get; set; }
        public List<TrainingGoal> CaregiverInterventions { get; set; }
        public List<TrainingGoal> CaregiverReplacements { get; set; }
        public List<TrainingGoal> CaregiverUseOfReinforcement { get; set; }
        public string RBTRationale { get; set; }
        public List<WorkSchedule> RBTWorkSchedule { get; set; }
        public string GeneralizationTraining { get; set; }
        public string RiskAssesment { get; set; }
        public string DischargeCriteria { get; set; } //????
        public string CrisisPlan { get; set; }
        public string DeEscalationTechniques { get; set; } //Store as JSON as an array of string
        public string ConsentToTreatment { get; set; }

    }
}