namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SurveyInListViewModel : IMapFrom<Survey>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Points { get; set; }
    }
}