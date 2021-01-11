using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Rotary
    {
        [Key]
        public int rotaryid { get; set; }
        [Required]
        public string rotary_name { get; set; }
        public string description { get; set; }
    }
}
