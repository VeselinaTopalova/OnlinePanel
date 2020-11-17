namespace SayOnlinePanel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Common.Models;

    public class Voucher : BaseDeletableModel<int>
    {
        public Voucher()
        {
            this.VoucherUsers = new HashSet<VoucherUser>();
        }

        [Required]
        public string Name { get; set; }

        public int Points { get; set; }

        public int Leva { get; set; }

        [Required]
        public string Image { get; set; }

        public string Description { get; set; }

        [Required]
        public string Company { get; set; }

        public ICollection<VoucherUser> VoucherUsers { get; set; }
    }
}
