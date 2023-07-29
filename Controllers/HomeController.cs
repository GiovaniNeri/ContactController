﻿using ContactController.DBContext;
using ContactController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactController.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Contact contact = new Contact();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}