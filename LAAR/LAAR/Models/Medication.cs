using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblMedication")]
    public class Medication
    {
        [Key]
        public int MedicationID { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Schedule { get; set; } //w, d
        public string SideEffects { get; set; }
        public string PrescribingPhysician { get; set; }
    }
}