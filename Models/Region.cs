using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Region
    {
        public int regionid { get; set; }
        [Required]
        public string regiontype { get; set; }
        public string description { get; set; }
    }
}
