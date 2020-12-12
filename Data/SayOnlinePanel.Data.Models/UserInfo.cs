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
            this.TargetSyrveyUserInfo = new HashSet<TargetSyrveyUserInfo>();
            this.SurveyUserInfos = new HashSet<SurveyUserInfo>();
        }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public Gender Gender { get; set; }

        public Town Town { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<SurveyUserInfo> SurveyUserInfos { get; set; }

        public ICollection<TargetSyrveyUserInfo> TargetSyrveyUserInfo { get; set; }

        public ICollection<UserAnswer> UserAnswers { get; set; }

        public int Points { get; set; } = 0;

        public ICollection<VoucherUser> VoucherUsers { get; set; }
    }
}
