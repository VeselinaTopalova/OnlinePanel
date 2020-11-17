namespace SayOnlinePanel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Common.Models;

    public class UserInfo : BaseDeletableModel<int>
    {
        public UserInfo()
        {
            this.VoucherUsers = new HashSet<VoucherUser>();
            this.UserAnswers = new HashSet<UserAnswer>();
        }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string Gender { get; set; }

        public string Town { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<UserAnswer> UserAnswers { get; set; }

        public ICollection<VoucherUser> VoucherUsers { get; set; }
    }
}
