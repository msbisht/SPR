using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class PricingStatus
    {
        public int statusid { get; set; }
        [Required]
        public string status_type { get; set; }
        public string description { get; set; }
    }
}
