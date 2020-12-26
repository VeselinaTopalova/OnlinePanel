namespace SayOnlinePanel.Web.Controllers
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Data;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.UserInfos;

    [Authorize]
    public class UserInfosController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;
        private readonly IUserInfosService userInfosService;

        public UserInfosController(UserManager<ApplicationUser> userManager, ApplicationDbContext db, IUserInfosService userInfosService)
        {
            this.userManager = userManager;
            this.db = db;
            this.userInfosService = userInfosService;
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
                    Points = s.isComplete == true ? s.Survey.PointsTotal : s.Survey.PointsStart,
                    Date = s.Survey.ModifiedOn.HasValue ? s.Survey.ModifiedOn.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) : null,
                }),
                VouchersUser = x.VoucherUsers.Select(v => new VoucherViewModel {
                Name = v.Voucher.Name,
                Points = v.Voucher.Points,
                })
                .ToList(),
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
            //var userInfo = this.userInfosRepository.All().FirstOrDefault(x => x.UserId == userId);
            var userInfo = this.db.UserInfos.FirstOrDefault(x => x.UserId == userId);

            if (userInfo != null)
            {
                var viewModel = new SyrveysListViewModel();
                viewModel.SurveysForUser = this.userInfosService.GetSurveysForUser(userId);
                return this.View(viewModel);
            }
            else
            {
                return this.Redirect("Create");
            }
        }

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

        public IActionResult Buy(int id)
        {
            var userId = this.userManager.GetUserId(this.User);
            var userInfo = this.db.UserInfos.FirstOrDefault(x => x.UserId == userId);
            var voucher = this.db.Vouchers.FirstOrDefault(x => x.Id == id);
            userInfo.Points -= voucher.Points;
            var voucherUser = new VoucherUser
            {
                VoucherId = voucher.Id,
                UserInfoId = userInfo.Id,
            };
            userInfo.VoucherUsers.Add(voucherUser);
            this.db.SaveChangesAsync();

            this.TempData["Message"] = "Успешно поръчахте този ваучер";
            return this.Redirect("/UserInfos/MyPoints");
        }
    }
}
