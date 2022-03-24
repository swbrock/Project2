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

        public IActionResult ViewAppointments()
        {
            var movies = tourContext.Tours
                .Include(x => x.TimeSlot)
                .OrderBy(x => x.TimeId)
                .ToList();
            return View(movies);
        }

        public IActionResult SignUp()
        {
            var times = tourContext.TimeSlots
                .OrderBy(x => x.IsAvailable)
                .OrderBy(x => x.TimeId)
                .ToList();
            return View(times);
        }
        [HttpGet]
        public IActionResult FinishForm(int timeid)
        {
            ViewBag.time = tourContext.TimeSlots.Single(x => x.TimeId == timeid).Time;
            ViewBag.day = tourContext.TimeSlots.Single(x => x.TimeId == timeid).Day;
            ViewBag.timeSlot = tourContext.TimeSlots.Single(x => x.TimeId == timeid);
            return View("Form");
        }
        
        [HttpPost]
        public IActionResult FinishForm(Tours tour)
        {
            var timeId = tour.TimeId;
            
            tourContext.Update(tour);
            tourContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int tourid)
        {
            var tour = tourContext.Tours.Single(x => x.TourId == tourid);
            return View(tour);
        }
        [HttpPost]
        public IActionResult Delete(Tours tour)
        {
            tourContext.Tours.Remove(tour);
            tourContext.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int tourid)
        {
            ViewBag.TimeSlots = tourContext.TimeSlots.ToList();

            var tours = tourContext.Tours.Single(x => x.TourId == tourid);
            return View("Form", tours);
        }
        [HttpPost]
        public IActionResult Edit(Tours tour)
        {
            tourContext.Update(tour);
            tourContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
