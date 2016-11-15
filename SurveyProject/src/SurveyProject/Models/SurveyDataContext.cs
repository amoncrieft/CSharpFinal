using Microsoft.EntityFrameworkCore;
using System;

namespace SurveyProject.Models
{
    public class SurveyDataContext : DbContext
    {
        public virtual DbSet<Survey> Surveys { get; set; }

        public SurveyDataContext(DbContextOptions<SurveyDataContext> options) : base(options)
        {
            
        }
        public void Create(string email, string program, int gender, int age, 
            int responses0, int responses1, int responses2, int responses3, int responses4, int responses5,
             int responses6, int responses7, int responses8, int responses9, string comments)
        {
            var survey = new Survey();
            survey.Email = email;
            survey.Program = program;
            survey.Gender = gender;
            survey.Age = age;
            survey.Responses0 = responses0;
            survey.Responses1 = responses1;
            survey.Responses2 = responses2;
            survey.Responses3 = responses3;
            survey.Responses4 = responses4;
            survey.Responses5 = responses5;
            survey.Responses6 = responses6;
            survey.Responses7 = responses7;
            survey.Responses8 = responses8;
            survey.Responses9 = responses9;
            survey.Comments = comments;

            Surveys.Add(survey);
            SaveChanges();
        }
    }
}

