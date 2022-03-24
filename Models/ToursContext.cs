using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class ToursContext : DbContext
    {
        public ToursContext(DbContextOptions<ToursContext> options) : base(options)
        {
            //Leave blank
        }
        public DbSet<Tours> Tours { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { TimeId = 1, Day = "Monday", IsAvailable = true, Time = "8:00 AM"},
                new TimeSlot { TimeId = 2, Day = "Monday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlot { TimeId = 3, Day = "Monday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlot { TimeId = 4, Day = "Monday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlot { TimeId = 5, Day = "Monday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 6, Day = "Monday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 7, Day = "Monday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 8, Day = "Monday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 9, Day = "Monday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 10, Day = "Monday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 11, Day = "Monday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 12, Day = "Monday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 13, Day = "Monday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlot { TimeId = 14, Day = "Tuesday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlot { TimeId = 15, Day = "Tuesday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlot { TimeId = 16, Day = "Tuesday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlot { TimeId = 17, Day = "Tuesday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlot { TimeId = 18, Day = "Tuesday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 19, Day = "Tuesday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 20, Day = "Tuesday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 21, Day = "Tuesday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 22, Day = "Tuesday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 23, Day = "Tuesday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 24, Day = "Tuesday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 25, Day = "Tuesday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 26, Day = "Tuesday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlot { TimeId = 27, Day = "Wednesday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlot { TimeId = 28, Day = "Wednesday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlot { TimeId = 29, Day = "Wednesday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlot { TimeId = 30, Day = "Wednesday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlot { TimeId = 31, Day = "Wednesday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 32, Day = "Wednesday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 33, Day = "Wednesday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 34, Day = "Wednesday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 35, Day = "Wednesday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 36, Day = "Wednesday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 37, Day = "Wednesday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 38, Day = "Wednesday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 39, Day = "Wednesday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlot { TimeId = 40, Day = "Thursday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlot { TimeId = 41, Day = "Thursday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlot { TimeId = 42, Day = "Thursday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlot { TimeId = 43, Day = "Thursday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlot { TimeId = 44, Day = "Thursday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 45, Day = "Thursday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 46, Day = "Thursday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 47, Day = "Thursday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 48, Day = "Thursday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 49, Day = "Thursday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 50, Day = "Thursday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 51, Day = "Thursday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 52, Day = "Thursday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlot { TimeId = 53, Day = "Thursday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlot { TimeId = 54, Day = "Thursday", IsAvailable = true, Time = "9:00 PM" },
                new TimeSlot { TimeId = 55, Day = "Thursday", IsAvailable = true, Time = "10:00 PM" },
                new TimeSlot { TimeId = 56, Day = "Thursday", IsAvailable = true, Time = "11:00 PM" },
                new TimeSlot { TimeId = 57, Day = "Thursday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 58, Day = "Thursday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 59, Day = "Thursday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 60, Day = "Thursday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 61, Day = "Thursday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 62, Day = "Thursday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 63, Day = "Thursday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 64, Day = "Thursday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 65, Day = "Thursday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlot { TimeId = 66, Day = "Friday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlot { TimeId = 67, Day = "Friday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlot { TimeId = 68, Day = "Friday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlot { TimeId = 69, Day = "Friday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlot { TimeId = 70, Day = "Friday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 71, Day = "Friday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 72, Day = "Friday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 73, Day = "Friday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 74, Day = "Friday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 75, Day = "Friday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 76, Day = "Friday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 77, Day = "Friday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 78, Day = "Friday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlot { TimeId = 79, Day = "Saturday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlot { TimeId = 80, Day = "Saturday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlot { TimeId = 81, Day = "Saturday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlot { TimeId = 82, Day = "Saturday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlot { TimeId = 83, Day = "Saturday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 84, Day = "Saturday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 85, Day = "Saturday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 86, Day = "Saturday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 87, Day = "Saturday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 88, Day = "Saturday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 89, Day = "Saturday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 90, Day = "Saturday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 91, Day = "Saturday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlot { TimeId = 92, Day = "Sunday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlot { TimeId = 93, Day = "Sunday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlot { TimeId = 94, Day = "Sunday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlot { TimeId = 95, Day = "Sunday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlot { TimeId = 96, Day = "Sunday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlot { TimeId = 97, Day = "Sunday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlot { TimeId = 98, Day = "Sunday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlot { TimeId = 99, Day = "Sunday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlot { TimeId = 100, Day = "Sunday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlot { TimeId = 101, Day = "Sunday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlot { TimeId = 102, Day = "Sunday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlot { TimeId = 103, Day = "Sunday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlot { TimeId = 104, Day = "Sunday", IsAvailable = true, Time = "8:00 PM" }
      
            );

        }

    }
}
