namespace SayOnlinePanel.Web.ViewModels.Users
{
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SurveyInListViewModel : IMapFrom<Survey>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Points { get; set; }

        public string Date { get; set; }
    }
}