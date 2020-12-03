namespace SayOnlinePanel.Web.Controllers
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Data;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.UserInfos;

    public class UserInfosController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;
        private readonly ISurveyService surveyService;
        private readonly IUserInfosService userInfosService;

        public UserInfosController(UserManager<ApplicationUser> userManager, ApplicationDbContext db, ISurveyService surveyService, IUserInfosService userInfosService)
        {
            this.userManager = userManager;
            this.db = db;
            this.surveyService = surveyService;
            this.userInfosService = userInfosService;
        }

        public async Task<IActionResult> MyPoints()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var userVM = this.db.UserInfos.Where(x => x.UserId == user.Id).Select(x => new SyrveysListViewModel
            {
                Points = x.Points,
                Surveys = x.Surveys.Select(s => new SurveysNamePoints
                {
                    Name = s.Name,
                    Points = s.PointsTotal,
                    Date = s.ModifiedOn.HasValue ? s.ModifiedOn.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) : null,
                }).ToList(),
            }).FirstOrDefault();
 
            if (userVM != null)
            {
                return this.View(userVM);
            }
            else
            {
                return this.Redirect("Create");
            }
        }

        public IActionResult CollectPoints()
        {
            var userId = this.userManager.GetUserId(this.User);
            var viewModel = new SyrveysListViewModel
            {
                Surveys = this.userInfosService.GetSurveysForUser<SurveysNamePoints>(userId),
            };
            return this.View(viewModel);
        }

        //[Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateUserInfoInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserInfoInputModel input)
        {
            var userId = this.userManager.GetUserId(this.User);
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.userInfosService.CreateAsync(input, userId);

            return this.Redirect("MyPoints");
        }
    }
}
