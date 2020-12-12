namespace SayOnlinePanel.Data.Models
{
    public class TargetUserAnswer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int TargetAnswerId { get; set; }

        public virtual TargetAnswer TargetAnswer { get; set; }

        public int TargetQuestionId { get; set; }

        public virtual TargetQuestion TargetQuestion { get; set; }

        public int TargetSurveyId { get; set; }

        public virtual TargetSurvey TargetSurvey { get; set; }

    }
}
