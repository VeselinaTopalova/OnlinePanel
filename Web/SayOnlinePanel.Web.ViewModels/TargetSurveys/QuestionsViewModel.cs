namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    //ok
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class QuestionsViewModel : IMapFrom<TargetQuestion>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TargetQuestionType TargetQuestionType { get; set; }

        public IEnumerable<AnswersViewModel> TargetAnswers { get; set; }

    }
}
