namespace SayOnlinePanel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Common.Models;

    public class Survey : BaseDeletableModel<int>
    {
        public Survey()
        {
            this.Questions = new HashSet<Question>();
            this.Users = new HashSet<ApplicationUser>();
            this.UserAnswers = new HashSet<UserAnswer>();
            this.SurveyUserInfos = new HashSet<SurveyUserInfo>();
        }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int SampleTotal { get; set; }

        public int SampleFemale { get; set; }

        public int SampleMale { get; set; }

        public int SampleTotalComplete { get; set; } = 0;

        public int SampleFemaleComplete { get; set; } = 0;

        public int SampleMaleComplete { get; set; } = 0;

        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<SurveyUserInfo> SurveyUserInfos { get; set; }

        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

        public int PointsStart { get; set; }

        public int PointsTotal { get; set; }

        public int TargetSurveyId { get; set; }

        public virtual TargetSurvey TargetSurvey { get; set; }
    }
}
