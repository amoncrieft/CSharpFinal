using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyProject.Models
{
    public class Results

    {
        public string Program  { get; set; }

        public double Experiential { get; set; }
       
        public double Entrepreneurial { get; set; }
        
        public double TwentyFirst { get; set; }

        public double Response0 { get; set; }
        public double Response1 { get; set; }
        public double Response2 { get; set; }
        public double Response3 { get; set; }
        public double Response4 { get; set; }
        public double Response5 { get; set; }
        public double Response6 { get; set; }
        public double Response7 { get; set; }
        public double Response8 { get; set; }
        public double Response9 { get; set; }
     }
}
