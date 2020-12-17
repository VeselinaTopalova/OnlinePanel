namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;
    using SayOnlinePanel.Web.ViewModels.TargetSurveys;

    public class TargetSurveyService : ITargetSurveyService
    {
        private readonly IDeletableEntityRepository<TargetSurvey> targetSurveysRepository;
        private readonly IDeletableEntityRepository<TargetQuestion> targetQuestionsRepository;
        private readonly IDeletableEntityRepository<TargetAnswer> targetAnswersRepository;

        public TargetSurveyService(
            IDeletableEntityRepository<TargetSurvey> targetSurveysRepository,
            IDeletableEntityRepository<TargetQuestion> targetQuestionsRepository,
            IDeletableEntityRepository<TargetAnswer> targetAnswersRepository)
        {
            this.targetSurveysRepository = targetSurveysRepository;
            this.targetQuestionsRepository = targetQuestionsRepository;
            this.targetAnswersRepository = targetAnswersRepository;
        }

        public async Task CreateAsync(CreateSurveyInputModel input)
        {
            var targetSurvey = new TargetSurvey
            {
                Name = input.Name,
                Description = input.Description,
                StartDate = input.StartDate,
                EndDate = input.EndDate,
            };

            foreach (var inputQuestion in input.Questions)
            {
                var isValidEnum = Enum.TryParse<TargetQuestionType>(inputQuestion.QuestionType, out TargetQuestionType test);

                if (!isValidEnum)
                {
                    throw new Exception($"Invalid question type!");
                }

                var question = new TargetQuestion
                {
                    Name = inputQuestion.Name,
                    TargetQuestionType = Enum.Parse<TargetQuestionType>(inputQuestion.QuestionType),
                };

                foreach (var inputAnswers in inputQuestion.Answers)
                {
                    question.TargetAnswers.Add(new TargetAnswer
                    {
                        Name = inputAnswers.Name,
                    });
                }

                targetSurvey.TargetQuestions.Add(question);
            }

            await this.targetSurveysRepository.AddAsync(targetSurvey);
            await this.targetSurveysRepository.SaveChangesAsync();
        }

        public async Task<int> CreateAsyncReturnId(CreateSurveyInputModel input)
        {
            var targetSurvey = new TargetSurvey
            {
                Name = input.Name,
                Description = input.Description,
                StartDate = input.StartDate,
                EndDate = input.EndDate,
            };

            foreach (var inputQuestion in input.Questions)
            {
                var isValidEnum = Enum.TryParse<TargetQuestionType>(inputQuestion.QuestionType, out TargetQuestionType test);

                if (!isValidEnum)
                {
                    throw new Exception($"Invalid question type!");
                }

                var question = new TargetQuestion
                {
                    Name = inputQuestion.Name,
                    TargetQuestionType = Enum.Parse<TargetQuestionType>(inputQuestion.QuestionType),
                };

                foreach (var inputAnswers in inputQuestion.Answers)
                {
                    question.TargetAnswers.Add(new TargetAnswer
                    {
                        Name = inputAnswers.Name,
                    });
                }

                targetSurvey.TargetQuestions.Add(question);
            }

            await this.targetSurveysRepository.AddAsync(targetSurvey);
            await this.targetSurveysRepository.SaveChangesAsync();
            return targetSurvey.Id;
        }

        public int GetCount()
        {
            return this.targetSurveysRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var surveys = this.targetSurveysRepository.All()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<T>().ToList();
            return surveys;
        }

        public IEnumerable<T> GetAllOnePage<T>(string id)
        {
            var surveys = this.targetSurveysRepository.All()
                .OrderByDescending(x => x.Id)
                .To<T>().ToList();
            return surveys;
        }

        public T GetById<T>(int id)
        {
            var survey = this.targetSurveysRepository.All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return survey;
        }

        public async Task UpdateAsync(int id, EditSurveyInputModel input)
        {
            var survey = this.targetSurveysRepository.All().FirstOrDefault(x => x.Id == id);
            survey.Name = input.Name;
            survey.Description = input.Description;
            survey.StartDate = input.StartDate;
            survey.EndDate = input.EndDate;

            if (input.TargetQuestions.Count() > 0)
            {
                foreach (var inputQuestion in input.TargetQuestions)
                {
                    var currQ = this.targetQuestionsRepository.All().FirstOrDefault(x => x.Id == inputQuestion.Id);
                    currQ.Name = inputQuestion.Name;
                    currQ.TargetQuestionType = inputQuestion.TargetQuestionType;
                    foreach (var inputAnswer in inputQuestion.TargetAnswers)
                    {
                        var currA = this.targetAnswersRepository.All().FirstOrDefault(x => x.Id == inputAnswer.Id);
                        currA.Name = inputAnswer.Name;
                    }
                }
            }

            await this.targetSurveysRepository.SaveChangesAsync();
            await this.targetQuestionsRepository.SaveChangesAsync();
            await this.targetAnswersRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var survey = this.targetSurveysRepository.All().FirstOrDefault(x => x.Id == id);
            this.targetSurveysRepository.Delete(survey);
            await this.targetSurveysRepository.SaveChangesAsync();
        }

        public async Task SelectedAnswers(PeopleSelectionViewModel model, int id)
        {
            throw new NotImplementedException();
        }
    }
}
