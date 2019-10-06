using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblNoteType")]
    public class NoteType
    {
        //NoteTypes could be so RBT Notes or Analyst Notes.
        [Key]
        public int NoteTypeID { get; set; }
        public string Name { get; set; }
    }
}