﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<TimeSlots> TimeSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlots>().HasData(
                new TimeSlots { TimeId = 1, Day = "Monday", IsAvailable = true, Time = "8:00 AM"},
                new TimeSlots { TimeId = 2, Day = "Monday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlots { TimeId = 3, Day = "Monday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlots { TimeId = 4, Day = "Monday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlots { TimeId = 5, Day = "Monday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 6, Day = "Monday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 7, Day = "Monday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 8, Day = "Monday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 9, Day = "Monday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 10, Day = "Monday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 11, Day = "Monday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 12, Day = "Monday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 13, Day = "Monday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlots { TimeId = 14, Day = "Tuesday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlots { TimeId = 15, Day = "Tuesday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlots { TimeId = 16, Day = "Tuesday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlots { TimeId = 17, Day = "Tuesday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlots { TimeId = 18, Day = "Tuesday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 19, Day = "Tuesday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 20, Day = "Tuesday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 21, Day = "Tuesday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 22, Day = "Tuesday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 23, Day = "Tuesday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 24, Day = "Tuesday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 25, Day = "Tuesday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 26, Day = "Tuesday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlots { TimeId = 27, Day = "Wednesday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlots { TimeId = 28, Day = "Wednesday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlots { TimeId = 29, Day = "Wednesday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlots { TimeId = 30, Day = "Wednesday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlots { TimeId = 31, Day = "Wednesday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 32, Day = "Wednesday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 33, Day = "Wednesday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 34, Day = "Wednesday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 35, Day = "Wednesday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 36, Day = "Wednesday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 37, Day = "Wednesday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 38, Day = "Wednesday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 39, Day = "Wednesday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlots { TimeId = 40, Day = "Thursday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlots { TimeId = 41, Day = "Thursday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlots { TimeId = 42, Day = "Thursday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlots { TimeId = 43, Day = "Thursday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlots { TimeId = 44, Day = "Thursday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 45, Day = "Thursday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 46, Day = "Thursday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 47, Day = "Thursday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 48, Day = "Thursday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 49, Day = "Thursday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 50, Day = "Thursday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 51, Day = "Thursday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 52, Day = "Thursday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlots { TimeId = 53, Day = "Thursday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlots { TimeId = 54, Day = "Thursday", IsAvailable = true, Time = "9:00 PM" },
                new TimeSlots { TimeId = 55, Day = "Thursday", IsAvailable = true, Time = "10:00 PM" },
                new TimeSlots { TimeId = 56, Day = "Thursday", IsAvailable = true, Time = "11:00 PM" },
                new TimeSlots { TimeId = 57, Day = "Thursday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 58, Day = "Thursday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 59, Day = "Thursday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 60, Day = "Thursday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 61, Day = "Thursday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 62, Day = "Thursday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 63, Day = "Thursday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 64, Day = "Thursday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 65, Day = "Thursday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlots { TimeId = 66, Day = "Friday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlots { TimeId = 67, Day = "Friday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlots { TimeId = 68, Day = "Friday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlots { TimeId = 69, Day = "Friday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlots { TimeId = 70, Day = "Friday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 71, Day = "Friday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 72, Day = "Friday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 73, Day = "Friday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 74, Day = "Friday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 75, Day = "Friday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 76, Day = "Friday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 77, Day = "Friday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 78, Day = "Friday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlots { TimeId = 79, Day = "Saturday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlots { TimeId = 80, Day = "Saturday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlots { TimeId = 81, Day = "Saturday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlots { TimeId = 82, Day = "Saturday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlots { TimeId = 83, Day = "Saturday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 84, Day = "Saturday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 85, Day = "Saturday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 86, Day = "Saturday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 87, Day = "Saturday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 88, Day = "Saturday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 89, Day = "Saturday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 90, Day = "Saturday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 91, Day = "Saturday", IsAvailable = true, Time = "8:00 PM" },
                new TimeSlots { TimeId = 92, Day = "Sunday", IsAvailable = true, Time = "8:00 AM" },
                new TimeSlots { TimeId = 93, Day = "Sunday", IsAvailable = true, Time = "9:00 AM" },
                new TimeSlots { TimeId = 94, Day = "Sunday", IsAvailable = true, Time = "10:00 AM" },
                new TimeSlots { TimeId = 95, Day = "Sunday", IsAvailable = true, Time = "11:00 AM" },
                new TimeSlots { TimeId = 96, Day = "Sunday", IsAvailable = true, Time = "12:00 PM" },
                new TimeSlots { TimeId = 97, Day = "Sunday", IsAvailable = true, Time = "1:00 PM" },
                new TimeSlots { TimeId = 98, Day = "Sunday", IsAvailable = true, Time = "2:00 PM" },
                new TimeSlots { TimeId = 99, Day = "Sunday", IsAvailable = true, Time = "3:00 PM" },
                new TimeSlots { TimeId = 100, Day = "Sunday", IsAvailable = true, Time = "4:00 PM" },
                new TimeSlots { TimeId = 101, Day = "Sunday", IsAvailable = true, Time = "5:00 PM" },
                new TimeSlots { TimeId = 102, Day = "Sunday", IsAvailable = true, Time = "6:00 PM" },
                new TimeSlots { TimeId = 103, Day = "Sunday", IsAvailable = true, Time = "7:00 PM" },
                new TimeSlots { TimeId = 104, Day = "Sunday", IsAvailable = true, Time = "8:00 PM" }
            );

        }

    }
}
