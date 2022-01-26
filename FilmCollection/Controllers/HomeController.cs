using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FilmCollection.Models;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieApplicationContext movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieApplicationContext x)
        {
            _logger = logger;
            movieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Movies(ApplicationResponse mv)
        {
            movieContext.Add(mv);
            movieContext.SaveChanges();

            return View("Confirmation", mv);
            //return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

    }
}
