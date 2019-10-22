using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblWorkSchedule")]
    public class WorkSchedule
    {
        [Key]
        public int WorkScheduleID { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Action { get; set; }
    }
}