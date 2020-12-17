namespace SayOnlinePanel.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Data;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.TargetSurveys;

    [Authorize(Roles = "Administrator")]
    public class TargetSurveysController : Controller
    {
        private readonly ITargetSurveyService targetSurveyService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;

        public TargetSurveysController(ITargetSurveyService targetSurveyService, UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            this.targetSurveyService = targetSurveyService;
            this.userManager = userManager;
            this.db = db;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateSurveyInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSurveyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            int targetSurveyId;
            try
            {
                //await this.targetSurveyService.CreateAsync(input);
                targetSurveyId = await this.targetSurveyService.CreateAsyncReturnId(input);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                return this.View(input);
            }

            //return this.RedirectToAction("Create", "Surveys", new { id = targetSurveyId });
            this.TempData["Message"] = "Target Survey added successfully.";
            return this.Redirect("TargetSurveys");
        }

        public IActionResult TargetSurveys(int id = 1)
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
                SurveysCount = this.targetSurveyService.GetCount(),
                Surveys = this.targetSurveyService.GetAll<SurveyInListViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var survey = this.targetSurveyService.GetById<SingleSurveyViewModel>(id);
            return this.View(survey);
        }

        public IActionResult Edit(int id)
        {
            var inputModel = this.targetSurveyService.GetById<EditSurveyInputModel>(id);
            return this.View(inputModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditSurveyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.targetSurveyService.UpdateAsync(id, input);
            return this.RedirectToAction(nameof(this.ById), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.targetSurveyService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.TargetSurveys));
        }

        public IActionResult SelectedAnswers(int id)
        {
            var model = new PeopleSelectionViewModel();

            model.TargetSurvey = this.targetSurveyService.GetById<SingleSurveyViewModel>(id);

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SelectedAnswers(PeopleSelectionViewModel model, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            foreach (var answeredQuestion in model.AnsweredQuestions)
            {
                var curTargetQuestion = this.db.TargetQuestions.FirstOrDefault(x => x.Id == answeredQuestion.Id);
                var s = new TargetSelectedAnswer
                {
                    TargetSurveyId = id,
                    TargetQuestionId = curTargetQuestion.Id,
                };

                foreach (var selectedAnswerId in answeredQuestion.SelectedAnswerIds)
                {
                    var curTargetAnswer = this.db.TargetAnswers.FirstOrDefault(x => x.Id == selectedAnswerId);

                    s.TargetAnswersHaveChecked.Add(curTargetAnswer);
                    await this.db.TargetSelectedAnswers.AddAsync(s);
                }
            }

            await this.db.SaveChangesAsync();
            return this.Redirect("/");
        }
    }
}
