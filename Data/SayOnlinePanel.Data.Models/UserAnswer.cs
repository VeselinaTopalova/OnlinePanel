namespace SayOnlinePanel.Data.Models
{
    public class UserAnswer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        public int SurveyId { get; set; }

        public virtual Survey Survey { get; set; }

        public string AnswerInput { get; set; }

        //public int TargetAnswerId { get; set; }

        //public virtual TargetAnswer TargetAnswer { get; set; }

        //public int TargetSurveyId { get; set; }

        //public virtual TargetSurvey TargetSurvey { get; set; }
    }
}
