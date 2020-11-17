namespace SayOnlinePanel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Common.Models;

    public class Question : BaseDeletableModel<int>
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
            this.Images = new HashSet<ImageForQuestion>();
        }

        public string Name { get; set; }

        public QuestionType QuestionType { get; set; }

        [Required]
        public int SurveyId { get; set; }

        public virtual Survey Survey { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        public virtual ICollection<ImageForQuestion> Images { get; set; }
    }
}
