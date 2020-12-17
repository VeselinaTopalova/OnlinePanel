namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PeopleSelectionViewModel
    {
        public SingleSurveyViewModel TargetSurvey;

        public List<AnsweredQuestion> AnsweredQuestions { get; set; }

        public PeopleSelectionViewModel()
        {
            this.AnsweredQuestions = new List<AnsweredQuestion>();
        }
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
