using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblNote")]
    public class Note
    {
        [Key]
        public int NoteID { get; set; }
        public NoteType NoteType { get; set; }
        public Client Client { get; set; }
        public Staff Staff { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int UnitsProvided { get; set; }
        public List<PlaceOfService> PlaceOfService { get; set; } 
        public string WorkWith { get; set; } //Multiselect???
        public Boolean BakerActed { get; set; }
        public Boolean DoctorVisit { get; set; }
        public Boolean Hospitalizations { get; set; }
        public Boolean MedicationChanged { get; set; }
        public Boolean IncidenReport { get; set; }
        public string Explain { get; set; }
        public string EnviromentalChanges { get; set; }
        public string PreferenceAssesmentResults { get; set; }
        public string MaladaptiveBehaviors { get; set; } //Store as Json array of int
        public string Interventions { get; set; } //Store as Json array of int
        public string ReplacementPrograms { get; set; } //Store as Json array of int
        public List<BehaviorService> BehaviorServices { get; set; }
        public string BriefDescription { get; set; }
        public Boolean NextVisitAgreement { get; set; }
        public string NextVisitAgreementExplain { get; set; }
        public DateTime NextVisitDate { get; set; }
        public String NextVisitPlace { get; set; }
    }
}