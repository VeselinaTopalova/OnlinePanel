namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;

    public class MyPointsViewModel
    {
        public SyrveysListViewModel Surveys { get; set; }

        public List<Voucher> VouchersUser { get; set; }
    }
}
