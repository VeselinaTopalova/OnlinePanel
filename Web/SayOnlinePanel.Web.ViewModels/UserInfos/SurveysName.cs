namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class SurveysName : IMapFrom<TargetSurvey>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PointsStart { get; set; }
    }
}
