namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class QuestionsTargetViewModel : IMapFrom<TargetQuestion>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TargetQuestionType TargetQuestionType { get; set; }

        public IEnumerable<AnswersTargetViewModel> TargetAnswers { get; set; }

    }
}
