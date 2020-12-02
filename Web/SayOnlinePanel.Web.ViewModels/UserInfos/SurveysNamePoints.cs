namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SurveysNamePoints : IMapFrom<Survey>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Points { get; set; }

        public string Date { get; set; }
    }
}
