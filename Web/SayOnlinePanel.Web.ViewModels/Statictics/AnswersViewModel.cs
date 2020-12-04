namespace SayOnlinePanel.Web.ViewModels.Statictics
{
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class AnswersViewModel : IMapFrom<Answer>
    {
        public string Name { get; set; }

        public int Count { get; set; }
    }
}