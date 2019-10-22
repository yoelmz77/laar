using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblObservation")]
    public class Observation
    {
        [Key]
        public int ObservationID { get; set; }
        public DateTime Date { get; set; }
        public string Observer { get; set; }
        public string SettingActivity { get; set; }
        public string Duration { get; set; }//w,d, m
        public string Tools { get; set; }    
    }
}