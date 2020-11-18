namespace SayOnlinePanel.Web.ViewModels.Vouchers
{
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class VoucherViewModel : IMapFrom<Voucher>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Points { get; set; }

        public int Leva { get; set; }

        [Required]
        public string Image { get; set; }

        public string Description { get; set; }

        [Required]
        public string Company { get; set; }
    }
}
