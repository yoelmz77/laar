using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblInserviceType")]
    public class InserviceType
    {
        /*
            ExpiresIn
            Background Screening 5 Years (5y)
            Local Police Record 1 Year (1y)
            Vehicle Registration 1 Year (1y)
            Insurance Card 6 month (6m)
            Liability 1 Year (1y)
            Good Ph/Mental Health 1 Year (1y)
            CPR/ First Aids 2 Years (2y)
            Bloodborne Pathogens 1 Year (1y)
            HIV/ Infection Control 1 Year (1y)
            Domestic Violence 1 Year (1y)
            HIPPA 1 Year (1y)
            OSHA 1 Year (1y)
            DCCC One time (ot)
            Zero Tolerance 3 Years (3y)
            Security Awareness 1 Year (1y)
            Civil Rights 1 Year (1y)
            License/Certif Due Date ???
            Supervision Monthly (1m)
        */
        [Key]
        public int InserviceTypeID { get; set; }
        public string ExpiresIn { get; set; }
        public string Name { get; set; }
    }
}