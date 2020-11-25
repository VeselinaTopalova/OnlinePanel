namespace SayOnlinePanel.Web.ViewModels.Surveys
{
    using System.Collections.Generic;

    public class SyrveysListViewModel : PagingViewModel
    {
        public IEnumerable<SurveyInListViewModel> Surveys { get; set; }
    }
}
