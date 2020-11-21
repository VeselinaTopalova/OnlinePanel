namespace SayOnlinePanel.Services.Data
{
    using System.Threading.Tasks;

    using SayOnlinePanel.Web.ViewModels.Surveys;

    public interface ISurveyService
    {
        Task CreateAsync(CreateSurveyInputModel input);

        Task CreateAsyncQuestions(CreateQuestionInputModel input);
    }
}
