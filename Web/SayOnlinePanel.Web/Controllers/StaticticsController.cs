using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SayOnlinePanel.Data;
using SayOnlinePanel.Data.Models;
using SayOnlinePanel.Services.Data;
using SayOnlinePanel.Web.ViewModels.Statictics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.Runtime.Serialization;

namespace SayOnlinePanel.Web.Controllers
{
    public class StaticticsController : Controller
    {
        private readonly IUsersService usersService;
        private readonly ISurveyService surveyService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;

        public StaticticsController(IUsersService usersService, ISurveyService surveyService, UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            this.usersService = usersService;
            this.surveyService = surveyService;
            this.userManager = userManager;
            this.db = db;
        }
        public IActionResult ByIdStatistics(int id)
        {
            //var survey = this.surveyService.GetById<SingleSurveyViewModel>(id);
            //return this.View(survey);
            //var survey = this.db.UserAnswers.Where(x => x.SurveyId == id).Select(x => new SingleSurveyViewModel
            //{
            //    Name = x.Survey.Name,
            //    Questions = x.Survey.Questions.Select(s => new QuestionsViewModel
            //    {
            //        Name = s.Name,
            //        QuestionType = s.QuestionType,
            //        Answers = s.Answers.Select(a=> new AnswersViewModel 
            //        { 
            //            Name = a.Name,
            //            Count = a.UserAnswers.Count(),
            //        }).ToList(),
            //    }).ToList(),
            //}).FirstOrDefault();
            //;
            //;
            //return this.View(survey);
            List<DataPoint> dataPoints = new List<DataPoint>();
            var d = new Dictionary<string, List<DataPoint>>();
            var survey = this.db.UserAnswers.Where(x => x.SurveyId == id).Select(x => new 
            {
                Name = x.Survey.Name,
                Questions = x.Survey.Questions.Select(s => new 
                {
                    Name = s.Name,
                    QuestionType = s.QuestionType,
                    Answers = s.Answers.Select(a => new 
                    {
                        Name = a.Name,
                        Count = a.UserAnswers.Count() 
                    }).ToList(),
                }).ToList(),
            }).FirstOrDefault();
            ;
            ;

            foreach (var item in survey.Questions)
            {
                d[item.Name] = new List<DataPoint>();
                foreach (var a in item.Answers)
                {
                    var n = new DataPoint(a.Name, a.Count);
                    d[item.Name].Add(n);
                }
            }
            ViewBag.d = JsonConvert.SerializeObject(d);
            ;
            ;
            List<DataPoint> dataPoints1 = new List<DataPoint>();

            dataPoints1.Add(new DataPoint("Economics", 1));
            dataPoints1.Add(new DataPoint("Physics", 2));
            dataPoints1.Add(new DataPoint("Literature", 4));
            dataPoints1.Add(new DataPoint("Chemistry", 4));
            dataPoints1.Add(new DataPoint("Literature", 9));
            dataPoints1.Add(new DataPoint("Physiology or Medicine", 11));
            dataPoints1.Add(new DataPoint("Peace", 13));

            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
            return View();
        }

        public class PieChartData
        {
            public string xValue;
            public double yValue;
        }

    }
    [DataContract]
    public class DataPoint
    {
        public DataPoint(string label, double y)
        {
            this.Label = label;
            this.Y = y;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "label")]
        public string Label = "";

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<double> Y = null;
    }
}
