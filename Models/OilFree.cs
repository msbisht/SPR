using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class OilFree
    {
        public int oilfreeId { get; set; }
        [Required]
        public string oilfreename { get; set; }
        public string description { get; set; }
    }
}
