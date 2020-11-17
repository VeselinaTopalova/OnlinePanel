namespace SayOnlinePanel.Data.Models
{
    public class UserAnswer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        //public int QuestionId { get; set; }

        //public virtual Question Question { get; set; }

        public string AnswerInput { get; set; }
    }
}
