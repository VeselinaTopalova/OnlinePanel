namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SingleSurveyViewModel : IMapFrom<Survey>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<QuestionsViewModel> Questions { get; set; }
    }
}
