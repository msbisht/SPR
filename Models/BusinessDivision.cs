using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class BusinessDivision
    {
        [Key]
        public int divisionId { get; set; }
        [Required]
        public int  OilfreeId { get; set; }
        public int rotaryId { get; set; }
        public int lrbuId { get; set; }
        public int smallairId { get; set; }
        public string divisionName { get; set; }
        public string description { get; set; }
    }
}
