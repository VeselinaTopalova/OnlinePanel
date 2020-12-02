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

        public UserInfosController(UserManager<ApplicationUser> userManager, ApplicationDbContext db, ISurveyService surveyService)
        {
            this.userManager = userManager;
            this.db = db;
            this.surveyService = surveyService;
        }

        public async Task<IActionResult> MyPoints(int id = 1)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            ;
            Console.WriteLine(user.Id);
            ;
            //var u = this.db.UserInfos.FirstOrDefault(x => x.UserId == user.Id);
            //var u = this.db.UserInfos.Where(x => x.UserId == user.Id).Select(x => new SyrveysListViewModel

            //{
            //    Surveys = x.Surveys.Select(s => new SurveysNamePoints
            //    {
            //        Name = s.Name,
            //        Points = s.PointsTotal,
            //        Date = s.ModifiedOn,
            //    }).ToList(),
            //}).ToList();
            var u = this.db.UserInfos.Where(x => x.UserId == user.Id).Select(x => new SyrveysListViewModel

            {
                Points = x.Points,
                Surveys = x.Surveys.Select(s => new SurveysNamePoints
                {
                    Name = s.Name,
                    Points = s.PointsTotal,
                    Date = s.ModifiedOn.HasValue ? s.ModifiedOn.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) : null,
                }).ToList(),
            }).FirstOrDefault();
            //var a = u.Count();
            ;
            //var surveys = u;
            //var viewModel = new SyrveysListViewModel
            //{
            //    Surveys = surveys.Select(s => new SurveysNamePoints
            //    {
            //        Name = s.,
            //        Points = s.PointsTotal,
            //        Date = s.ModifiedOn,
            //    }).ToList()
            //};
            return this.View(u);
        }
    }
}
