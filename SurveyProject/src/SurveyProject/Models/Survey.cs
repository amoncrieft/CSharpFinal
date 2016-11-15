using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyProject.Models
{
    public class Survey
    {
        public int ID { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Program { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public int Responses0 { get; set; }
        public int Responses1 { get; set; }
        public int Responses2 { get; set; }
        public int Responses3 { get; set; }
        public int Responses4 { get; set; }
        public int Responses5 { get; set; }
        public int Responses6 { get; set; }
        public int Responses7 { get; set; }
        public int Responses8 { get; set; }
        public int Responses9 { get; set; }
        public string Comments { get; set; }



        public static List<SurveyDataContext> GetAll()
        {
            return GlobalVariables.Surveys;
        }

    }
}
