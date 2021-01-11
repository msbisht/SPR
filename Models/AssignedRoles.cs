using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class AssignedRoles
    {
        public int assignedrolesid { get; set; }
        [Required]
        public string assignto { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int RegistrationID { get; set; }
    }
}
