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
        //[HttpPost]
        //public JsonResult AjaxMethod(string name)
        //{
        //    PersonModel person = new PersonModel
        //    {
        //        Name = name,
        //        DateTime = DateTime.Now.ToString()
        //    };
        //    return Json(person);
        //}

        //public IActionResult ByIdStatistics(int id)
        //public JsonResult ByIdStatistics(int id)
        public string ByIdStatistics(int id)
        {
            //var survey = this.surveyService.GetById<SingleSurveyViewModel>(id);
            var survey = this.db.UserAnswers.Where(x => x.SurveyId == id).Select(x => new SingleSurveyViewModel
            {
                Name = x.Survey.Name,
                Questions = x.Survey.Questions.Select(s => new QuestionsViewModel
                {
                    Name = s.Name,
                    QuestionType = s.QuestionType,
                    Answers = s.Answers.Select(a => new AnswersViewModel
                    {
                        Name = a.Name,
                        Count = a.UserAnswers.Count(),
                    }).ToList(),
                }).ToList(),
            }).FirstOrDefault();
            ;
            ;
            //return this.View(survey);
            var jsonResult = JsonConvert.SerializeObject(survey, Formatting.Indented);

            return jsonResult;
            //return Json(survey);
        }

        public IActionResult SampleComplete(int id)
        {
            var survey = this.db.UserAnswers.Where(x => x.SurveyId == id).Select(x => new CompleteModel
            {
                Name = x.Survey.Name,
                SampleTotalComplete = x.Survey.SampleTotalComplete,
                SampleTotalCompletePercent = (x.Survey.SampleTotal != 0) ? (x.Survey.SampleTotalComplete / x.Survey.SampleTotal) * 100 : 0,
                SampleMaleComplete = x.Survey.SampleMaleComplete,
                SampleMale = x.Survey.SampleMale,
                SampleMaleCompletePercent = x.Survey.SampleMale != 0 ? (x.Survey.SampleMaleComplete / x.Survey.SampleMale) * 100 : 0,
                SampleFemaleComplete = x.Survey.SampleFemaleComplete,
                SampleFemaleCompletePercent = x.Survey.SampleFemale != 0 ? (x.Survey.SampleFemaleComplete / x.Survey.SampleFemale) * 100 : 0,
                SampleFemale = x.Survey.SampleFemale,
            }).FirstOrDefault();
            ;
            ;

            int completeTotal = this.db.UserAnswers.Where(x => x.SurveyId == id).Select(x => x.Survey.SampleTotalComplete).FirstOrDefault();
            int sampleTotal = this.db.UserAnswers.Where(x => x.SurveyId == id).Select(x => x.Survey.SampleTotal).FirstOrDefault();


            return this.View(survey);
        }

    }
}
