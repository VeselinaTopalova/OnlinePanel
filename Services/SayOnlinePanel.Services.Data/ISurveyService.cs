namespace SayOnlinePanel.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Web.ViewModels.Surveys;

    public interface ISurveyService
    {
        Task CreateAsync(CreateSurveyInputModel input);

        //IEnumerable<T> GetAll<T>(int? count = null);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        IEnumerable<T> GetAllOnePage<T>(string id);

        int GetCount();

        T GetById<T>(int id);

        Task UpdateAsync(int id, EditSurveyInputModel input);
    }
}
