namespace SayOnlinePanel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Common.Models;

    public class Answer : BaseDeletableModel<int>
    {
        public Answer()
        {
            this.Images = new HashSet<ImageForAnswer>();
            this.Users = new HashSet<ApplicationUser>();
            this.UserAnswers = new HashSet<UserAnswer>();
        }

        public string Name { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        //public int SurveyId { get; set; }

        //public virtual Survey Survey { get; set; }

        public virtual ICollection<ImageForAnswer> Images { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
