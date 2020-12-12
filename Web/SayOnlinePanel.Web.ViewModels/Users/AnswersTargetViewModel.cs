namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System.ComponentModel.DataAnnotations;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class AnswersTargetViewModel : IMapFrom<TargetAnswer>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
