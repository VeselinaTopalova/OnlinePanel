namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Web.ViewModels.Users;

    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<Survey> surveysRepository;

        public UsersService(IDeletableEntityRepository<Survey> surveysRepository)
        {
            this.surveysRepository = surveysRepository;
        }

        public async Task CompleteAsync(PeopleSelectionViewModel model, int id, string userId)
        {
            var answeredQuestions = model.AnsweredQuestions;

            foreach (var answeredQuestion in answeredQuestions)
            {
                foreach (var selectedAnswerId in answeredQuestion.SelectedAnswerIds)
                {
                    var s = new UserAnswer
                    {
                        SurveyId = id,
                        UserId = userId,
                        AnswerId = selectedAnswerId,
                    };
                }

                foreach (var answer in answeredQuestion.InputAnswers)
                {
                    var s = new UserAnswer
                    {
                        SurveyId = id,
                        UserId = userId,
                        AnswerId = answer.Id,
                        AnswerInput = answer.Input,
                    };
                }
            }
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
