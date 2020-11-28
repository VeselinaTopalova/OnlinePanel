namespace SayOnlinePanel.Web.ViewModels.Users
{
    using System.Collections.Generic;

    public class SyrveysListViewModel : PagingViewModel
    {
        public IEnumerable<SurveyInListViewModel> Surveys { get; set; }
    }
}
