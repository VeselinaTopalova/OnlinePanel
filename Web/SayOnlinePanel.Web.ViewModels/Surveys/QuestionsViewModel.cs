namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class QuestionsViewModel : IMapFrom<Question>
    {
        public string Name { get; set; }

        public QuestionType QuestionType { get; set; }

        public IEnumerable<AnswersViewModel> Answers { get; set; }

    }
}
