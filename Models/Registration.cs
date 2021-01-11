using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        [Required]
        public string name { get; set; }
        public string mobileno { get; set; }
        public string emailid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string gender { get; set; }
        public DateTime birthdate { get; set; }
        public int roleID { get; set; }
        public DateTime createdOn { get; set; }
        public string emplooyeeid { get; set; }
        public string forcechangepassword { get; set; }
    }
}
