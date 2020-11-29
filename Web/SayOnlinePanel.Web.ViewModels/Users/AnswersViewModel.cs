namespace SayOnlinePanel.Web.ViewModels.Users
{
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class AnswersViewModel : IMapFrom<Answer>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
