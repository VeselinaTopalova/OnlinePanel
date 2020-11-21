namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Web.ViewModels.Surveys;

    public class SurveyService : ISurveyService
    {
        private readonly IDeletableEntityRepository<Survey> surveysRepository;
        private readonly IDeletableEntityRepository<Question> questionsRespository;

        public SurveyService(IDeletableEntityRepository<Survey> surveysRepository,
            IDeletableEntityRepository<Question> questionsRespository)
        {
            this.surveysRepository = surveysRepository;
            this.questionsRespository = questionsRespository;
        }

        public async Task CreateAsync(CreateSurveyInputModel input)
        {
            var survey = new Survey
            {
                Name = input.Name,
                Description = input.Description,
                StartDate = input.StartDate,
                EndDate = input.EndDate,
                SampleTotal = input.SampleTotal,
                SampleFemale = input.SampleFemale,
                SampleMale = input.SampleMale,
                PointsStart = input.PointsStart,
                PointsTotal = input.PointsTotal,
            };

            foreach (var inputQuestion in input.Questions)
            {
                QuestionType qt = (QuestionType)Enum.Parse(typeof(QuestionType), inputQuestion.QuestionType, true);
                var question = new Question
                {
                    Name = inputQuestion.Name,
                    QuestionType = qt,
                };
                foreach (var inputAnswers in inputQuestion.Answers)
                {
                    question.Answers.Add(new Answer
                    {
                        Name = inputAnswers.Name,
                    });
                }

                survey.Questions.Add(question);
            }

            await this.surveysRepository.AddAsync(survey);
            await this.surveysRepository.SaveChangesAsync();
        }

        public async Task CreateAsyncQuestions(CreateQuestionInputModel input)
        {

        }
    }
}
