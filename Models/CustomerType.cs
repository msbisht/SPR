using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class CustomerType
    {
        public int customerTypeId { get; set; }
        [Required]
        public string customertypename { get; set; }
        public string description { get; set; }
    }
}
