namespace SayOnlinePanel.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class IndexViewModel
    {
        public List<IndexVoucherViewModel> Vouchers { get; set; }
    }
}
