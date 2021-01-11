using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class LRBU
    {
        [Key]
        public int lrbuid { get; set; }
        [Required]
        public string lrbuname { get; set; }
        public string description { get; set; }
    }
}
