﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ConferenceRoomManager.Data;
using ConferenceRoomManager.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace ConferenceRoomManager.Controllers
{
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookingsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            string Id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = _db.Users.FirstOrDefault(user => user.Id == Id);

            if (user == null)
            {
                Content("No user is found.");
                return LocalRedirect("Index");
            }

            var Booking = _db.Bookings.Include("Room").Where(i => i.UserId.Equals(user.Id)).ToList();
            if (Booking == null)
            {
                return Content("No bookings to show.");
            }

            ViewData["Bookings"] = Booking;
            return View();

        }
        public IActionResult Book()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Book([Bind("UserName", "Date", "UserId", "RoomId")] BookingModel Booking)
        {
            string Id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = _db.Users.FirstOrDefault(user => user.Id == Id);

            DateTime today = DateTime.Today;
            DateTime futureDate = today.AddDays(5);

            if (user == null)
            {
                Content("No user is found.");
                return LocalRedirect("Index");
            }

            if (ModelState.IsValid)
            {
                var userEmail = user.UserName.Split("@")[0];
                var userNames = userEmail.Split(".");
                var userName = userNames[0];
                Booking.UserName = userName;
                Booking.UserId = user.Id;
                //Booking.RoomId = 1;
                _db.Bookings.Add(Booking);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var booking = _db.Bookings.Include("Room").ToList().Find(b => b.Id == id);
            if (id == null || booking == null)
            {
                return View("_NotFound");
            }
            ViewData["booking"] = booking;
            return View();
        }
        [HttpPost]
        public IActionResult Edit([Bind("Id", "UserName", "Date", "UserId", "RoomId")] BookingModel booking)
        {
            _db.Bookings.Update(booking);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var booking = _db.Bookings.ToList().Find(b => b.Id == id);

            if (id == null || booking == null)
            {
                return View("_NotFound");
            }
            _db.Bookings.Remove(booking);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
