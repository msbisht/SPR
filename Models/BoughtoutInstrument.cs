using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class BoughtoutInstrument
    {
        public int boughtoutid { get; set; }
        [Required]
        public string boughtoutname { get; set; }
        public string description { get; set; }
    }
}
