﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblMaladaptiveBehavior")]
    public class MaladaptiveBehavior
    {
        [Key]
        public int MaladaptiveBehaviorID { get; set; }
        public int Name { get; set; }
    }
}