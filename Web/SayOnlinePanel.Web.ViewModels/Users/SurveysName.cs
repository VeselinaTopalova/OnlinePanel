namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SurveysName : IMapFrom<Survey>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
