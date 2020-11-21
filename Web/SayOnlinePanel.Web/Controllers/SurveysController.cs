namespace SayOnlinePanel.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.Surveys;

    public class SurveysController : Controller
    {
        private readonly ISurveyService surveyService;

        public SurveysController(ISurveyService surveyService)
        {
            this.surveyService = surveyService;
        }
        
        public IActionResult Create()
        {
            var viewModel = new CreateSurveyInputModel();
            //viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSurveyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.surveyService.CreateAsync(input);

            // TODO: Redirect to ???
            return this.Redirect("CreateQuestions");
        }

        public IActionResult CreateQuestions()
        {
            var viewModel = new CreateQuestionInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestions(CreateQuestionInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.surveyService.CreateAsyncQuestions(input);

            // TODO: Redirect to ???
            return this.Redirect("/");
        }
    }
}
