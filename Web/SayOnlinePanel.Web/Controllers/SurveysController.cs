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
            return this.Redirect("Surveys");
        }

        public IActionResult Surveys(int id = 1)
        {
            //var viewModel = new SyrveysListViewModel();
            //viewModel.Surveys = this.surveyService.GetAll<SurveysName>();
            //return this.View(viewModel);

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
    }
}
