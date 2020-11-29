namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System.Collections.Generic;

    public class PeopleSelectionViewModel
    {
        public SingleSurveyViewModel Survey;

        public List<int> Answers { get; set; }

        public List<AnswersInput> AnswersInput { get; set; }

        public List<int> AreChecked { get; set; }

        public PeopleSelectionViewModel()
        {
            this.Answers = new List<int>();
            this.AreChecked = new List<int>();

        }
    }
    public class AnswersInput
    {
        public int QId { get; set; }

        public string Text { get; set; }
    }
}
