namespace SayOnlinePanel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using SayOnlinePanel.Data;
    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.UserInfos;

    public class UserInfosController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;
        private readonly ISurveyService surveyService;
        private readonly IUserInfosService userInfosService;
        private readonly IDeletableEntityRepository<UserInfo> userInfosRepository;

        public UserInfosController(UserManager<ApplicationUser> userManager, ApplicationDbContext db, ISurveyService surveyService, IUserInfosService userInfosService, IDeletableEntityRepository<UserInfo> userInfosRepository)
        {
            this.userManager = userManager;
            this.db = db;
            this.surveyService = surveyService;
            this.userInfosService = userInfosService;
            this.userInfosRepository = userInfosRepository;
        }

        public async Task<IActionResult> MyPoints()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var userVM = this.db.UserInfos.Where(x => x.UserId == user.Id).Select(x => new SyrveysListViewModel
            {
                Points = x.Points,
                Surveys = x.SurveyUserInfos
                .Select(s => new SurveysNamePoints
                {
                    Name = s.Survey.Name,
                    Points = s.isComplete == true? s.Survey.PointsTotal : s.Survey.PointsStart,
                    Date = s.Survey.ModifiedOn.HasValue ? s.Survey.ModifiedOn.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) : null,
                })
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
            ;
            var userInfo = this.db.UserInfos.FirstOrDefault(x => x.UserId == userId);

            if (userInfo != null)
            {
                var surveysForUser = new List<Survey>();
                if (userInfo.Gender == Data.Models.Gender.Male)
                {
                   surveysForUser = this.db.Surveys
                .OrderByDescending(x => x.Id)
                .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now
                    && w.SampleMale > 0)
                .Include(x => x.TargetSurvey)
                .ThenInclude(x => x.TargetSyrveyUserInfos)
                .ToList();
                }

                else if(userInfo.Gender == Data.Models.Gender.Female)
                {
                    surveysForUser = this.db.Surveys
                .OrderByDescending(x => x.Id)
                .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now
                    && w.SampleFemale > 0)
                .Include(x => x.TargetSurvey)
                .ThenInclude(x => x.TargetSyrveyUserInfos)
                .ToList();
                }
                for (int i = 0; i < surveysForUser.Count; i++)
                {
                    var TSUI = surveysForUser[i].TargetSurvey.TargetSyrveyUserInfos.Where(x => x.TargetSurveyId == surveysForUser[i].TargetSurveyId && x.UserInfoId == userInfo.Id).FirstOrDefault();
                    if (surveysForUser[i].TargetSurvey.TargetSyrveyUserInfos.Contains(TSUI))
                    {
                        surveysForUser.Remove(surveysForUser[i]);
                    }
                }

                var viewModel = new SyrveysListViewModel();
                viewModel.SurveysForUser = surveysForUser;
                return this.View(viewModel);
            }
            else
            {
                return this.Redirect("Create");
            }
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

            try
            {
                await this.userInfosService.CreateAsync(input, userId);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                return this.View(input);
            }            

            return this.Redirect("MyPoints");
        }
    }
}
