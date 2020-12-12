using System.Collections.Generic;

namespace SayOnlinePanel.Data.Models
{
    public class TargetSelectedAnswer
    {
        //public int Id { get; set; }

        //public int TargetAnswerId { get; set; }

        //public virtual TargetAnswer TargetAnswer { get; set; }

        //public int TargetQuestionId { get; set; }

        //public virtual TargetQuestion TargetQuestion { get; set; }

        //public int TargetSurveyId { get; set; }

        //public virtual TargetSurvey TargetSurvey { get; set; }

        public TargetSelectedAnswer()
        {
            this.TargetAnswersHaveChecked = new HashSet<TargetAnswer>();
        }

        public int Id { get; set; }

        public int TargetQuestionId { get; set; }

        public virtual TargetQuestion TargetQuestion { get; set; }

        public virtual ICollection<TargetAnswer> TargetAnswersHaveChecked { get; set; }

        public int TargetSurveyId { get; set; }

        public virtual TargetSurvey TargetSurvey { get; set; }

    }
}
