using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPR.Models
{
    public class Channel
    {
        public int channelid { get; set; }
        [Required]
        public string channelType { get; set; }
        public string description { get; set; }
    }
}
