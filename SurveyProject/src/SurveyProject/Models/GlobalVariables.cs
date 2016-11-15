using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyProject.Models
{
    public class GlobalVariables
    {
    public static List<SurveyProject.Models.SurveyDataContext> Surveys { get; set; }
        = new List<SurveyDataContext>();
    }
}
