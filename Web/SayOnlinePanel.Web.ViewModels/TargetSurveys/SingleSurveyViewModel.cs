namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    //ok
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SingleSurveyViewModel : IMapFrom<TargetSurvey>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<QuestionsViewModel> TargetQuestions { get; set; }
    }
}
