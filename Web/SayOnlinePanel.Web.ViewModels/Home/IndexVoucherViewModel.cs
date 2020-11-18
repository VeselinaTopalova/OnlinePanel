namespace SayOnlinePanel.Web.ViewModels.Home
{
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class IndexVoucherViewModel : IMapFrom<Voucher>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Points { get; set; }

        public int Leva { get; set; }

        [Required]
        public string Image { get; set; }

        public string Description { get; set; }

        public string Company { get; set; }
    }
}
