using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Competition
    {
        public int competitionid { get; set; }
        [Required]
        public string competitionname { get; set; }
        public string description { get; set; }
    }
}
