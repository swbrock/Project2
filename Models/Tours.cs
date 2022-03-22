using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(15)] //fix this to be a number 15 not length 
        public int GroupSize { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public EmailAddressAttribute EmailAddress { get; set; }
        public PhoneAttribute Phone { get; set; }

    }
}
