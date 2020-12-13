namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System.Collections.Generic;

    using SayOnlinePanel.Data.Models;

    public class SyrveysListViewModel
    {
        public int Points { get; set; }

        public IEnumerable<SurveysNamePoints> Surveys { get; set; }

        public IEnumerable<Survey> SurveysForUser { get; set; }
    }
}
