﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Testy.Models;

namespace Testy.Controllers
{
    public class HomeController : Controller
    {
        // Comment added
        // Some changes during stash

        public IActionResult Index()
        {
            // Feature 1 added
            return View();
        }

        public IActionResult About()
        {
            // Feature 2 added

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            // Feature 6 added
            // More changes in Fetaure 6
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            // Changes in branch master
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
