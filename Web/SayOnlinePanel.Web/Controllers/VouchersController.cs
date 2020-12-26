namespace SayOnlinePanel.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Data;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.Vouchers;

    public class VouchersController : Controller
    {
        private readonly IVouchersService vouchersService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserInfosService userInfosService;
        private readonly ApplicationDbContext db;

        public VouchersController(IVouchersService vouchersService, UserManager<ApplicationUser> userManager, IUserInfosService userInfosService, ApplicationDbContext db)
        {
            this.vouchersService = vouchersService;
            this.userManager = userManager;
            this.userInfosService = userInfosService;
            this.db = db;
        }

        public IActionResult All()
        {
            var viewModel = new AllVouchersViewModel();

            var vouchers = this.vouchersService.GetAll<VoucherViewModel>();
            viewModel.Vouchers = vouchers;

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var voucherViewModel = this.vouchersService.GetById<VoucherViewModel>(id);
            if (voucherViewModel == null)
            {
                return this.NotFound();
            }

            var userid = this.userManager.GetUserId(this.User);
            if (userid == null)
            {
                this.ViewData["userPoints"] = 0;
            }
            else
            {
                //var userPoints = this.userInfosService.GetUsersPointsForVoucher(userid);
                var userPoints = this.db.UserInfos.FirstOrDefault(x => x.UserId == userid).Points;

                this.ViewData["userPoints"] = userPoints;
            }

            return this.View(voucherViewModel);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            var viewModel = new CreateVoucherInputModel();
            return this.View(viewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateVoucherInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.vouchersService.CreateAsync(input);

            this.TempData["Message"] = "Voucher added successfully.";
            return this.Redirect("All");
        }
    }
}
