﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAAR.Models
{
    [Table("tblBehaviorService")]
    public class BehaviorService
    {
        [Key]
        public int BehaviorServiceID { get; set; }
        public int Name { get; set; }

    }
}