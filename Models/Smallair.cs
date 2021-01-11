using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Smallair
    {
        [Key]
        public int smallairid { get; set; }
        [Required]
        public string smallairname { get; set; }
        public string description { get; set; }
    }
}
