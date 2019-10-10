using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblStaff")]
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }
        public string Name { get; set; } //Fullname, it could be breaddown into firstname, lastname
        public string Address { get; set; } //Break Down address allows search by street address/city/state/zip
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; } //Administrator/OfficeManager/Staff/H2014/H2012/H2019/T1017
        public string EducationalLevel { get; set; } //High School/Bachelor/Master
        public string LegalStatus { get; set; } //Citizen/ Authorized to Work
        public int ProviderID { get; set; }
        public List<License> Licenses {get; set;} 
        public double Rate { get; set; } 
        public Credential Credential { get; set; } //LMHC/LSW/BCBA/BCaBA/RBT/BS/Other(blank space) ?????
        public string Initial { get; set; } //image format storage
        public string Signature { get; set; } //image format storage

    }


}