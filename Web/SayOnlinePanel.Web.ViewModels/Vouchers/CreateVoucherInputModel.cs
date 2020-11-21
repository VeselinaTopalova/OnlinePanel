namespace SayOnlinePanel.Web.ViewModels.Vouchers
{
    using System.ComponentModel.DataAnnotations;

    public class CreateVoucherInputModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(100)]
        public string Description { get; set; }

        //[Range(1, 100)]
        public int Points { get; set; }

        public int Leva { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Company { get; set; }
    }
}
