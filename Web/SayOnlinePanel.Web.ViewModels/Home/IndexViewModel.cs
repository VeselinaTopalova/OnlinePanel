namespace SayOnlinePanel.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class IndexViewModel
    {
        public IEnumerable<IndexVoucherViewModel> Vouchers { get; set; }
    }
}
