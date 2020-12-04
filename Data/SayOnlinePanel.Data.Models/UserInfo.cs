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
            this.Surveys = new HashSet<Survey>();
        }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public Gender Gender { get; set; }

        public Town Town { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<Survey> Surveys { get; set; }

        public ICollection<UserAnswer> UserAnswers { get; set; }

        public int Points { get; set; } = 0;

        public ICollection<VoucherUser> VoucherUsers { get; set; }
    }
}
