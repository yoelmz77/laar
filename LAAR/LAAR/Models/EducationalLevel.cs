using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace LAAR.Models
{
    //enum EducationalLevel
    //{
    //    HighSchool = 1,
    //    Bachelor = 2,
    //    Master = 3,
    //    PhD = 4,
    //}
    [Table("tblEducationalLevel")]
    public class EducationalLevel
    {
        [Key]
        public int EducationalLevelID { get; set; }
        public string EducationalLevelName { get; set; }
    }
}