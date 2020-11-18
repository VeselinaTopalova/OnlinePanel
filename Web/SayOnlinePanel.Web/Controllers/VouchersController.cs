namespace SayOnlinePanel.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Services.Data;
    using SayOnlinePanel.Web.ViewModels.Vouchers;

    public class VouchersController : Controller
    {
        private readonly IVouchersService vouchersService;

        public VouchersController(IVouchersService vouchersService)
        {
            this.vouchersService = vouchersService;
        }

        public IActionResult ByName(string name)
        {
            var viewModel = this.vouchersService.GetByName<VoucherViewModel>(name);
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var voucherViewModel = this.vouchersService.GetById<VoucherViewModel>(id);
            if (voucherViewModel == null)
            {
                return this.NotFound();
            }

            return this.View(voucherViewModel);
        }

        //[Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateVoucherInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVoucherInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.vouchersService.CreateAsync(input);

            // TODO: Redirect to ???
            return this.Redirect("/");
        }
    }
}
