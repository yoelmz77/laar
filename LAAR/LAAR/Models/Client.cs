using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblClient")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string Name { get; set; } //Fullname, it could be breaddown into firstname, lastname
        public int RecipientID { get; set; }
        public int ClientNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DiagnosisCode> DiagnosisCode { get; set; }
        public int MCD { get; set; }
        public List<PAApproved> PAApproved { get; set; }
        public string CaregiverName { get; set; }
        public string CaregiverAddress { get; set; } //Break Down address allows search by street address/city/state/zip
        public string CaregiverAddress2 { get; set; }
        public string CaregiverCity { get; set; }
        public string CaregiverState { get; set; }
        public string CaregiverZip { get; set; }
        public string CaregiverPhoneNumber { get; set; }
        public string CaregiverEmail { get; set; }
        public string CaregiverInitials { get; set; }
        public string CaregiverSignature { get; set; }
        public List<Staff> StaffAssigned { get; set; }
    }
}