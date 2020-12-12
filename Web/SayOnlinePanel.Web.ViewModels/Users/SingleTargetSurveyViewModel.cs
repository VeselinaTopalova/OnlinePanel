namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SingleTargetSurveyViewModel : IMapFrom<TargetSurvey>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<QuestionsTargetViewModel> TargetQuestions { get; set; }
    }
}
