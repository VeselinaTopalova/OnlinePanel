namespace SayOnlinePanel.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using SayOnlinePanel.Data.Common.Models;

    public class TargetQuestion : BaseDeletableModel<int>
    {
        public TargetQuestion()
        {
            this.TargetAnswers = new HashSet<TargetAnswer>();
            //this.TargetAnswersHaveChecked = new HashSet<TargetAnswer>();
            //this.TargetAnswersHaveCheckedIds = new List<int>();
        }

        public string Name { get; set; }

        public TargetQuestionType TargetQuestionType { get; set; }

        [Required]
        public int TargetSurveyId { get; set; }

        public virtual TargetSurvey TargetSurvey { get; set; }

        public virtual ICollection<TargetAnswer> TargetAnswers { get; set; }

        //public virtual ICollection<TargetAnswer> TargetAnswersHaveChecked { get; set; }

        //[NotMapped]
        //public List<int> TargetAnswersHaveCheckedIds { get; set; }
    }
}
