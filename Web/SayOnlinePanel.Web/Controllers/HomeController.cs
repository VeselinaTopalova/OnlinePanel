namespace SayOnlinePanel.Web.Controllers
{
    using System.Diagnostics;

    using SayOnlinePanel.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using SayOnlinePanel.Services.Data;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using SayOnlinePanel.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IVouchersService vouchersService;

        public HomeController(IVouchersService vouchersService)
        {
            this.vouchersService = vouchersService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            viewModel.Vouchers = this.vouchersService.GetAll<IndexVoucherViewModel>();
            return this.View(viewModel);
        }

        public IActionResult Privacy()
            {
                return this.View();
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
