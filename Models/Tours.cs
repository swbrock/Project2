using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Tours
    {
        [Key]
        [Required]
        public int TourId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15)]
        public int GroupSize { get; set; }
        [Required]
        [ForeignKey("TimeSlot")]
        public int TimeId { get; set; }
        [Required]
        public TimeSlot TimeSlot { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string Phone { get; set; }

    }
}
