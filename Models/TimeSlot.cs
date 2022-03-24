using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int TimeId { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}