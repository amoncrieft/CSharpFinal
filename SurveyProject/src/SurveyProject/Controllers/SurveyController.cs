using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyProject.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SurveyProject.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyDataContext _context;
        public SurveyController(SurveyDataContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        
       public IActionResult ViewSurveys()
        {
            //return View(Models.Survey.GetAll());
            return View(_context.Surveys);
        }

        public IActionResult GenerateSurveys(int n)
        {
            //return View(Models.Survey.GetAll());
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                var survey = new Survey { Email = "a@b.c", Age = 22, Comments = "Idea Center Rocks!", Gender = r.Next(0,2), Program = "WebDev",
                    Responses0 = r.Next(0, 2),
                    Responses1 = r.Next(0, 2),
                    Responses2 = r.Next(0, 2),
                    Responses3 = r.Next(0, 2),
                    Responses4 = r.Next(0, 2),
                    Responses5 = r.Next(0, 2),
                    Responses6 = r.Next(0, 2),
                    Responses7 = r.Next(0, 2),
                    Responses8 = r.Next(0, 2),
                    Responses9 = r.Next(0, 2),
                };
                _context.Add(survey);
            }
            for (int i = 0; i < n; i++)
            {
                var survey = new Survey
                {
                    Email = "a@b.c",
                    Age = 22,
                    Comments = "Idea Center Rocks!",
                    Gender = r.Next(0, 2),
                    Program = "Design for Miami",
                    Responses0 = r.Next(0, 2),
                    Responses1 = r.Next(0, 2),
                    Responses2 = r.Next(0, 2),
                    Responses3 = r.Next(0, 2),
                    Responses4 = r.Next(0, 2),
                    Responses5 = r.Next(0, 2),
                    Responses6 = r.Next(0, 2),
                    Responses7 = r.Next(0, 2),
                    Responses8 = r.Next(0, 2),
                    Responses9 = r.Next(0, 2),
                };
                _context.Add(survey);
            }
            for (int i = 0; i < n; i++)
            {
                var survey = new Survey
                {
                    Email = "a@b.c",
                    Age = 22,
                    Comments = "Idea Center Rocks!",
                    Gender = r.Next(0, 2),
                    Program = "CS50x Miami",
                    Responses0 = r.Next(0, 2),
                    Responses1 = r.Next(0, 2),
                    Responses2 = r.Next(0, 2),
                    Responses3 = r.Next(0, 2),
                    Responses4 = r.Next(0, 2),
                    Responses5 = r.Next(0, 2),
                    Responses6 = r.Next(0, 2),
                    Responses7 = r.Next(0, 2),
                    Responses8 = r.Next(0, 2),
                    Responses9 = r.Next(0, 2),
                };
                _context.Add(survey);
            }
            for (int i = 0; i < n; i++)
            {
                var survey = new Survey
                {
                    Email = "a@b.c",
                    Age = 22,
                    Comments = "Idea Center Rocks!",
                    Gender = r.Next(0, 2),
                    Program = "MarketHack",
                    Responses0 = r.Next(0, 2),
                    Responses1 = r.Next(0, 2),
                    Responses2 = r.Next(0, 2),
                    Responses3 = r.Next(0, 2),
                    Responses4 = r.Next(0, 2),
                    Responses5 = r.Next(0, 2),
                    Responses6 = r.Next(0, 2),
                    Responses7 = r.Next(0, 2),
                    Responses8 = r.Next(0, 2),
                    Responses9 = r.Next(0, 2),
                };
                _context.Add(survey);
            }
            for (int i = 0; i < n; i++)
            {
                var survey = new Survey
                {
                    Email = "a@b.c",
                    Age = 22,
                    Comments = "Idea Center Rocks!",
                    Gender = r.Next(0, 2),
                    Program = "Make1",
                    Responses0 = r.Next(0, 2),
                    Responses1 = r.Next(0, 2),
                    Responses2 = r.Next(0, 2),
                    Responses3 = r.Next(0, 2),
                    Responses4 = r.Next(0, 2),
                    Responses5 = r.Next(0, 2),
                    Responses6 = r.Next(0, 2),
                    Responses7 = r.Next(0, 2),
                    Responses8 = r.Next(0, 2),
                    Responses9 = r.Next(0, 2),
                };
                _context.Add(survey);
            }
            for (int i = 0; i < n; i++)
            {
                var survey = new Survey
                {
                    Email = "a@b.c",
                    Age = 22,
                    Comments = "Idea Center Rocks!",
                    Gender = r.Next(0, 2),
                    Program = "Innovation M",
                    Responses0 = r.Next(0, 2),
                    Responses1 = r.Next(0, 2),
                    Responses2 = r.Next(0, 2),
                    Responses3 = r.Next(0, 2),
                    Responses4 = r.Next(0, 2),
                    Responses5 = r.Next(0, 2),
                    Responses6 = r.Next(0, 2),
                    Responses7 = r.Next(0, 2),
                    Responses8 = r.Next(0, 2),
                    Responses9 = r.Next(0, 2),
                };
                _context.Add(survey);
            }
            _context.SaveChanges();
            return View("ViewSurveys", _context.Surveys);
        }

        //[HttpPost]

        public IActionResult Create(string email, string program, int gender, int age,
            int responses0, int responses1, int responses2, int responses3, int responses4, int responses5,
             int responses6, int responses7, int responses8, int responses9, string comments)
        {
           
            _context.Create(email, program, gender, age, responses0, responses1, responses2, responses3,
                responses4, responses5, responses6, responses7, responses8, responses9, comments);
            return RedirectToAction("ViewSurveys");
        } 
    }
}
