﻿namespace SayOnlinePanel.Data.Models
{
    public class VoucherUser
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int VoucherId { get; set; }

        public virtual Voucher Voucher { get; set; }
    }
}
