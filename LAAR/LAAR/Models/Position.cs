using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    //enum PositionType
    //{
    //    Administrator = 1,
    //    OfficeManager = 2,
    //    Staff = 3,
    //    H2014 = 14,
    //    H2012 = 12,
    //    H2019 = 19,
    //    T1017 = 17
    //}
    [Table("tblPosition")]
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public String Name { get; set; }

    }
}