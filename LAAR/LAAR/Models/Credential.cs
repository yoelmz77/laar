using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblCredential")]
    public class Credential
    {
        [Key]
        public int CredentialID { get; set; }
        public string Name { get; set; }
    }
}