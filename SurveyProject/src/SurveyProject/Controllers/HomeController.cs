using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyProject.Models;

namespace SurveyProject.Controllers
{
    public class HomeController : Controller
    {

    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Results()
        {
            return View();
        }

        public IActionResult Survey()
        {
            return View();
        }
        public IActionResult GenerateSurveys()
        {
            return View();
        }
    }
}
