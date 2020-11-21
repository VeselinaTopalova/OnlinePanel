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
        }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int SampleTotal { get; set; }

        public int SampleFemale { get; set; }

        public int SampleMale { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        //public virtual ICollection<Answer> Answers { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

        public int PointsStart { get; set; }

        public int PointsTotal { get; set; }
    }
}
