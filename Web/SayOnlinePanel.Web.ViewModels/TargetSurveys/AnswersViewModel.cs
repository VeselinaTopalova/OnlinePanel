﻿namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class AnswersViewModel : IMapFrom<TargetAnswer>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
