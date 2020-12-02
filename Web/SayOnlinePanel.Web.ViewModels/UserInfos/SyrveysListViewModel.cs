namespace SayOnlinePanel.Web.ViewModels.UserInfos
{
    using System.Collections.Generic;

    public class SyrveysListViewModel
    {
        public int Points { get; set; }

        public IEnumerable<SurveysNamePoints> Surveys { get; set; }
    }
}
