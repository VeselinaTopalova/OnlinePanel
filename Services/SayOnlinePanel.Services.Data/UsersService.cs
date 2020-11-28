namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
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

        public async Task CreateAsync(SQAnswerInputModel input, int id, string userId)
        {
            var survey = this.surveysRepository.All().FirstOrDefault(x => x.Id == id);
            var s = new UserAnswer
            {
                SurveyId = id,
                UserId = userId,
            };

            //foreach (var inputAnswer in input.Answers)
            //{
            //    var question = new Question
            //    {
            //        Id = inputAnswer.id,
            //    };
                

            //    //survey.Questions.Add(question);
            //}

            await this.surveysRepository.AddAsync(survey);
            await this.surveysRepository.SaveChangesAsync();
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
