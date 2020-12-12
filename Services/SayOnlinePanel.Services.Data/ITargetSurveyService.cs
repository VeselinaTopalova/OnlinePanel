namespace SayOnlinePanel.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SayOnlinePanel.Web.ViewModels.TargetSurveys;

    public interface ITargetSurveyService
    {
        Task CreateAsync(CreateSurveyInputModel input);

        Task<int> CreateAsyncReturnId(CreateSurveyInputModel input);

        int GetCount();

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        IEnumerable<T> GetAllOnePage<T>(string id);

        T GetById<T>(int id);

        Task UpdateAsync(int id, EditSurveyInputModel input);

        Task DeleteAsync(int id);

        Task SelectedAnswers(PeopleSelectionViewModel model, int id);
    }
}
