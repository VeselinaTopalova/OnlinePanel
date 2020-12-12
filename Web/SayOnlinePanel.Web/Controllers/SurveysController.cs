namespace SayOnlinePanel.Web.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.Surveys;

    public class SurveysController : Controller
    {
        private readonly ISurveyService surveyService;
        private readonly IWebHostEnvironment environment;

        public SurveysController(ISurveyService surveyService, IWebHostEnvironment environment)
        {
            this.surveyService = surveyService;
            this.environment = environment;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateSurveyInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSurveyInputModel input, int? idTarget)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.surveyService.CreateAsync(input, idTarget);
            return this.Redirect("Surveys");
        }

        public IActionResult Surveys(int id = 1)
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
                SurveysCount = this.surveyService.GetCount(),
                Surveys = this.surveyService.GetAll<SurveyInListViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var survey = this.surveyService.GetById<SingleSurveyViewModel>(id);
            return this.View(survey);
        }

        public IActionResult Edit(int id)
        {
            var inputModel = this.surveyService.GetById<EditSurveyInputModel>(id);
            return this.View(inputModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditSurveyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.surveyService.UpdateAsync(id, input);
            return this.RedirectToAction(nameof(this.ById), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.surveyService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.Surveys));
        }
    }
}
