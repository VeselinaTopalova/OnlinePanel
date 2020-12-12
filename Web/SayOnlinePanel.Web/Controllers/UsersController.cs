namespace SayOnlinePanel.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Data;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.Users;

    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        private readonly ISurveyService surveyService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;
        private readonly ITargetSurveyService targetSurveyService;

        public UsersController(IUsersService usersService, ISurveyService surveyService,
            UserManager<ApplicationUser> userManager, ApplicationDbContext db, ITargetSurveyService targetSurveyService)
        {
            this.usersService = usersService;
            this.surveyService = surveyService;
            this.userManager = userManager;
            this.db = db;
            this.targetSurveyService = targetSurveyService;
        }

        public IActionResult CompleteTargetSurvey(int id)
        {
            var model = new TargetPeopleSelectionViewModel();

            model.TargetSurvey = this.targetSurveyService.GetById<SingleTargetSurveyViewModel>(id);

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CompleteTargetSurvey(TargetPeopleSelectionViewModel model, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var user = await this.userManager.GetUserAsync(this.User);
            var userInfo = this.db.UserInfos.FirstOrDefault(x => x.UserId == user.Id);
            var survey = this.db.Surveys.FirstOrDefault(x => x.TargetSurveyId == id);
            var targetSurvey = this.db.TargetSurveys.FirstOrDefault(x => x.Id == id);
            var TSUI = this.db.TargetSyrveyUserInfos.Where(x => x.TargetSurveyId == id && x.UserInfoId == userInfo.Id).FirstOrDefault();

            if (TSUI != null)
            {
                return this.Redirect("/");
            }

            var tsui = new TargetSyrveyUserInfo { TargetSurvey = targetSurvey, UserInfo = userInfo };
            var sui = new SurveyUserInfo { Survey = survey, UserInfo = userInfo };
            userInfo.TargetSyrveyUserInfo.Add(tsui);
            userInfo.SurveyUserInfos.Add(sui); 



            ////is targetAnswersHaveCheckedIds is checked
            bool isInList = false;
            foreach (var answeredQuestion in model.AnsweredQuestions)
            {
                var currQuestion = this.db.TargetQuestions.FirstOrDefault(x => x.Id == answeredQuestion.Id);
                var targetAnswersHaveCheckedIds = this.db.TargetSelectedAnswers.Where(x => x.TargetQuestion.Id == answeredQuestion.Id)
                    .Select(s => s.TargetAnswersHaveChecked)
                    .FirstOrDefault().ToList();


                foreach (var selectedAnswerId in answeredQuestion.SelectedAnswerIds)
                {
                    //isInList = false;
                    var currAnswer = this.db.TargetAnswers.FirstOrDefault(x => x.Id == selectedAnswerId);
                    if (targetAnswersHaveCheckedIds.IndexOf(currAnswer) != -1)
                    {
                        isInList = true;
                    }
                    else
                    {
                        //break;
                    }
                }
            }

            if (isInList)
            {
                if (userInfo.Gender == Gender.Male && survey.SampleMaleComplete < survey.SampleMale)
                {
                    await this.db.SaveChangesAsync();
                    return this.RedirectToAction("CompleteSurvey", "Users", new { id = survey.Id });
                }
                else if (userInfo.Gender == Gender.Female && survey.SampleFemaleComplete < survey.SampleFemale)
                {
                    await this.db.SaveChangesAsync();
                    return this.RedirectToAction("CompleteSurvey", "Users", new { id = survey.Id });
                }
                else
                {
                    userInfo.Points += survey.PointsStart;
                    await this.db.SaveChangesAsync();
                    return this.RedirectToAction("ThankYou", "Users", new { id = survey.Id });
                }
            }
            else
            {
                
                userInfo.Points += survey.PointsStart;
                await this.db.SaveChangesAsync();
                return this.RedirectToAction("ThankYou", "Users", new { id = survey.Id });
            }
        }

        public IActionResult CompleteSurvey(int id)
        {
            var model = new PeopleSelectionViewModel();

            model.Survey = this.surveyService.GetById<SingleSurveyViewModel>(id);

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CompleteSurvey(PeopleSelectionViewModel model, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }
            var user = await this.userManager.GetUserAsync(this.User);

            //this.usersService.CompleteAsync(model, id, user.Id);
            // get the ids of the items selected:
            var answeredQuestions = model.AnsweredQuestions;

            foreach (var answeredQuestion in answeredQuestions)
            {
                foreach (var selectedAnswerId in answeredQuestion.SelectedAnswerIds)
                {
                    var s = new UserAnswer
                    {
                        SurveyId = id,
                        UserId = user.Id,
                        AnswerId = selectedAnswerId,
                    };
                    await this.db.UserAnswers.AddAsync(s);
                }

                foreach (var answer in answeredQuestion.InputAnswers)
                {
                    var s = new UserAnswer
                    {
                        SurveyId = id,
                        UserId = user.Id,
                        AnswerId = answer.Id,
                        AnswerInput = answer.Input,
                    };
                    await this.db.UserAnswers.AddAsync(s);
                }
            }

            var survey = this.db.Surveys.FirstOrDefault(x => x.Id == id);
            var userInfo = this.db.UserInfos.FirstOrDefault(x => x.UserId == user.Id);

            if (userInfo != null)
            {
                userInfo.Points += survey.PointsTotal;
            }
            else
            {
                var ui = new UserInfo
                {
                    UserId = user.Id,
                };

                ui.Points = survey.PointsTotal;

                await this.db.UserInfos.AddAsync(ui);
            }

            var sui = this.db.SurveyUserInfos.Where( s=>s.Survey == survey && s.UserInfo == userInfo).FirstOrDefault();
            sui.isComplete = true;

            //Sample
            survey.SampleTotalComplete += 1;

            if(userInfo.Gender == Gender.Male)
            {
                survey.SampleMaleComplete += 1;
            }
            else
            {
                survey.SampleFemaleComplete += 1;
            }

            await this.db.SaveChangesAsync();
            return this.Redirect("/");
        }

        public IActionResult ThankYou(int id)
        {
            var points = this.db.Surveys.FirstOrDefault(x => x.Id == id).PointsStart;
            ViewData["points"] = points;

            return this.View();
        }
    }
}
