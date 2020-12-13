namespace SayOnlinePanel.Web.ViewModels.Statictics
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class QuestionsViewModel : IMapFrom<Question>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public QuestionType QuestionType { get; set; }

        //public IEnumerable<AnswersViewModel> Answers { get; set; }
        public List<AnswersViewModel> Answers { get; set; }

    }
}
