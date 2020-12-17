namespace SayOnlinePanel.Data.Models
{
    public class VoucherUser
    {
        public int Id { get; set; }

        public int UserInfoId { get; set; }

        public UserInfo UserInfo { get; set; }

        public int VoucherId { get; set; }

        public virtual Voucher Voucher { get; set; }
    }
}
