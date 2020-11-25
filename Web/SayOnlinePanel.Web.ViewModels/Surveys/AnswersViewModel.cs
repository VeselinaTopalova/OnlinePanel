namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class AnswersViewModel : IMapFrom<Answer>
    {
        public string Name { get; set; }
    }
}
