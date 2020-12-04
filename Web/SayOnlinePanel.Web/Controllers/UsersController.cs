namespace SayOnlinePanel.Web.Controllers
{
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

        public UsersController(IUsersService usersService, ISurveyService surveyService, UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            this.usersService = usersService;
            this.surveyService = surveyService;
            this.userManager = userManager;
            this.db = db;
        }

        
        //public IActionResult CollectPoints()
        //{            
        //    var viewModel = new SyrveysListViewModel
        //    {
        //        Surveys = this.surveyService.GetAllOnePage<SurveyInListViewModel>(id),
        //    };
        //    return this.View(viewModel);
        //}

        public IActionResult ById(int id)
        {
            var survey = this.surveyService.GetById<SingleSurveyViewModel>(id);
            return this.View(survey);
        }

        public IActionResult CompleteSurvey(int id)
        {
            var model = new PeopleSelectionViewModel();

            model.Survey = this.surveyService.GetById<SingleSurveyViewModel>(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CompleteSurvey(PeopleSelectionViewModel model, int id)
        {
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

            var survey = db.Surveys.FirstOrDefault(x => x.Id == id);
            //add survey to Survey's list of user
            var userInfo = db.UserInfos.FirstOrDefault(x => x.UserId == user.Id);
            ;
            ;
            if(userInfo != null)
            {
                userInfo.Surveys.Add(survey);
                userInfo.Points += survey.PointsTotal;
            }
            else
            {
                var ui = new UserInfo
                {
                    UserId = user.Id,
                };
                ui.Surveys.Add(survey);

                //add points of user
                ui.Points = survey.PointsTotal;

                await this.db.UserInfos.AddAsync(ui);
            }

            //add user to User's list of survey
            if (survey.Users.Contains(user))
            {
                //?????????
            }
            else
            {
                survey.Users.Add(user);
            }

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
    }
}
