using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class roles
    {
        [Key]
        public int roleid { get; set; }
        [Required]
        public string rolename { get; set; }
    }
}
