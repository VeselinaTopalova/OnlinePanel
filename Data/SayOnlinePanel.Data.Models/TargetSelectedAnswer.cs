namespace SayOnlinePanel.Data.Models
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Common.Models;

    public class TargetSelectedAnswer //: BaseDeletableModel<int>
    {
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
