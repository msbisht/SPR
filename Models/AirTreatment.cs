using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class AirTreatment
    {
        public int airtreatmentid { get; set; }
        [Required]
        public string treatmentname { get; set; }
        public string description { get; set; }
    }
}
