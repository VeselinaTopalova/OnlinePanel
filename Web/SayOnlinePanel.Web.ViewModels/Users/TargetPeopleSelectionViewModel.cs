namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class TargetPeopleSelectionViewModel
    {
        public SingleTargetSurveyViewModel TargetSurvey;

        public List<AnsweredQuestion> AnsweredQuestions { get; set; }

        public TargetPeopleSelectionViewModel()
        {
            this.AnsweredQuestions = new List<AnsweredQuestion>();
        }

        public class AnsweredQuestion
        {
            [Required]
            public int Id { get; set; }

            public List<int> SelectedAnswerIds { get; set; }

            public AnsweredQuestion()
            {
                this.SelectedAnswerIds = new List<int>();
            }

        }
    }

}
