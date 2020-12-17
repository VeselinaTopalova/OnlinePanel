namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    using System.Collections.Generic;

    public class SyrveysListViewModel : PagingViewModel
    {
        public IEnumerable<SurveyInListViewModel> Surveys { get; set; }
    }
}
