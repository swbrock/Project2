using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{

    public class HomeController : Controller
    {
        private ToursContext tourContext { get; set; }
        public HomeController(ToursContext someName)
        {
            tourContext = someName;
        }
        public IActionResult Index()
        {
            return View();
        }

        //    [HttpGet]
        //    public IActionResult ViewAppointments()
        //    {
        //        var appointments = 

        //        return View();
        //    }

        public IActionResult SignUp()
        {
            var times = tourContext.TimeSlots
                .OrderBy(x => x.TimeId)
                .ToList();
            return View(times);
        }
        [HttpGet]
        public IActionResult FinishForms(int timeid)
        {
            ViewBag.TimeSlots = tourContext.TimeSlots.ToList();
            var time = tourContext.TimeSlots.Single(x => x.TimeId == timeid);
            return View("Form", time);
        }
    }
}
