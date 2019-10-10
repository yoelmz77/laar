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
        public List<MaladaptiveBehavior> MaladaptiveBehaviors { get; set; }
        public List<Intervention> Interventions { get; set; }
        public List<ReplacementProgram> ReplacementPrograms { get; set; }
        public List<BehaviorService> BehaviorServices { get; set; }
    }
}