using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblPlaceOfService")]
    public class PlaceOfService
    {

        // PLace of Service Home(12), Community(99), School/Daycare(03)

        [Key]
        public int PlaceOfServiceID { get; set; }
        public string Name { get; set; }
    }
}