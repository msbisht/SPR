﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Industry
    {
        [Key]
        public int industryid { get; set; }
        [Required]
        public string industrytype { get; set; }
        public string description { get; set; }
    }
}
