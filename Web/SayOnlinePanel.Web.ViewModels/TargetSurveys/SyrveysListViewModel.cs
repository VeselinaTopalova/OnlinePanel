namespace SayOnlinePanel.Web.ViewModels.TargetSurveys
{
    //ok
    using System.Collections.Generic;

    public class SyrveysListViewModel : PagingViewModel
    {
        public IEnumerable<SurveyInListViewModel> Surveys { get; set; }
    }
}
