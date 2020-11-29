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
    }
}
