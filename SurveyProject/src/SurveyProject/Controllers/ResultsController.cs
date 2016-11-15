using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyProject.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SurveyProject.Controllers
{
    public class ResultsController : Controller
    {
        private readonly SurveyDataContext _context;
        public ResultsController(SurveyDataContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var responses = _context.Surveys;
            var results = new Models.Results();
            results.Program = "Overall";
            results.Response0 = responses.Average(p => p.Responses0) * 100;
            results.Response1 = responses.Average(p => p.Responses1) * 100;
            results.Response2 = responses.Average(p => p.Responses2) * 100;
            results.Response3 = responses.Average(p => p.Responses3) * 100;
            results.Response4 = responses.Average(p => p.Responses4) * 100;
            results.Response5 = responses.Average(p => p.Responses5) * 100;
            results.Response6 = responses.Average(p => p.Responses6) * 100;
            results.Response7 = responses.Average(p => p.Responses7) * 100;
            results.Response8 = responses.Average(p => p.Responses8) * 100;
            results.Response9 = responses.Average(p => p.Responses9) * 100;

            results.Experiential = ((results.Response0 + results.Response1 + results.Response2 + results.Response3) / 4) ;
            results.Entrepreneurial = ((results.Response4 + results.Response5 + results.Response6) / 3) ;
            results.TwentyFirst = ((results.Response7 + results.Response8 + results.Response9) / 3) ;

            return View("Results", results);

            
        }
        //[HttpGet]
        public IActionResult GetOverallResults()
        {
            var responses = _context.Surveys;
            var results = new Models.Results();
            results.Program = "Overall";
            results.Response0 = responses.Average(p => p.Responses0);
            results.Response1 = responses.Average(p => p.Responses1);
            results.Response2 = responses.Average(p => p.Responses2);
            results.Response3 = responses.Average(p => p.Responses3);
            results.Response4 = responses.Average(p => p.Responses4);
            results.Response5 = responses.Average(p => p.Responses5);
            results.Response6 = responses.Average(p => p.Responses6);
            results.Response7 = responses.Average(p => p.Responses7);
            results.Response8 = responses.Average(p => p.Responses8);
            results.Response9 = responses.Average(p => p.Responses9);

            results.Experiential = ((results.Response0 + results.Response1 + results.Response2 + results.Response3) / 4) * 100;
            results.Entrepreneurial = ((results.Response4 + results.Response5 + results.Response6) / 3) * 100;
            results.Experiential = ((results.Response7 + results.Response8 + results.Response9) / 3) * 100;

            return View("Results", results);
        }

        [HttpPost]

        public IActionResult GetResults(string program)
        {
            var responses = _context.Surveys;
            
            var responses2 = _context.Surveys.Where(p => p.Program.Equals(program));
                       
            var results = new SurveyProject.Models.Results();
            if (program == "Overall")
            { 
            results.Program = program;
            results.Response0 = responses.Average(p => p.Responses0)*100;
            results.Response1 = responses.Average(p => p.Responses1)*100;
            results.Response2 = responses.Average(p => p.Responses2)*100;
            results.Response3 = responses.Average(p => p.Responses3)*100;
            results.Response4 = responses.Average(p => p.Responses4) * 100;
            results.Response5 = responses.Average(p => p.Responses5) * 100;
            results.Response6 = responses.Average(p => p.Responses6) * 100;
            results.Response7 = responses.Average(p => p.Responses7) * 100;
            results.Response8 = responses.Average(p => p.Responses8) * 100;
            results.Response9 = responses.Average(p => p.Responses9) * 100;

            results.Experiential = ((results.Response0 + results.Response1 + results.Response2 + results.Response3) / 4);
            results.Entrepreneurial = ((results.Response4 + results.Response5 + results.Response6) / 3);
            results.TwentyFirst = ((results.Response7 + results.Response8 + results.Response9) / 3);
            }
            else
            {
                results.Program = program;
                results.Response0 = responses2.Average(p => p.Responses0) *100;
                results.Response1 = responses2.Average(p => p.Responses1) * 100;
                results.Response2 = responses2.Average(p => p.Responses2) * 100;
                results.Response3 = responses2.Average(p => p.Responses3) * 100;
                results.Response4 = responses2.Average(p => p.Responses4) * 100;
                results.Response5 = responses2.Average(p => p.Responses5) * 100;
                results.Response6 = responses2.Average(p => p.Responses6) * 100;
                results.Response7 = responses2.Average(p => p.Responses7) * 100;
                results.Response8 = responses2.Average(p => p.Responses8) * 100;
                results.Response9 = responses2.Average(p => p.Responses9) * 100;

                results.Experiential = ((results.Response0 + results.Response1 + results.Response2 + results.Response3) / 4);
                results.Entrepreneurial = ((results.Response4 + results.Response5 + results.Response6) / 3);
                results.TwentyFirst = ((results.Response7 + results.Response8 + results.Response9) / 3);
            }
            return View("Results", results);
        }

    }
}
