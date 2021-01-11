using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Facility
    {
        public int facilityid { get; set; }
        [Required]
        public string facilityname { get; set; }
        public string description { get; set; }
    }
}
