namespace SayOnlinePanel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
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

        public IActionResult SurveysForUser(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 12;
            var viewModel = new SyrveysListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                RecipesCount = this.surveyService.GetCount(),
                Surveys = this.surveyService.GetAll<SurveyInListViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

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
            ;
            await this.db.SaveChangesAsync();
            return this.Redirect("/");
        }
    }
}
