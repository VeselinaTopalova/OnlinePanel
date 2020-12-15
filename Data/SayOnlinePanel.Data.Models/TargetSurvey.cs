namespace SayOnlinePanel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Common.Models;

    public class TargetSurvey : BaseDeletableModel<int>
    {
        public TargetSurvey()
        {
            this.TargetQuestions = new HashSet<TargetQuestion>();
            this.Users = new HashSet<ApplicationUser>();
            this.TargetUserAnswers = new HashSet<TargetUserAnswer>();
            this.TargetSyrveyUserInfos = new HashSet<TargetSyrveyUserInfo>();
        }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public virtual ICollection<TargetQuestion> TargetQuestions { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<TargetSyrveyUserInfo> TargetSyrveyUserInfos { get; set; }

        public virtual ICollection<TargetUserAnswer> TargetUserAnswers { get; set; }

        //public int PointsStart { get; set; }
    }
}
