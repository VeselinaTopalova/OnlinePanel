namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;
    using SayOnlinePanel.Web.ViewModels.Surveys;

    public class SurveyService : ISurveyService
    {
        private readonly IDeletableEntityRepository<Survey> surveysRepository;
        private readonly IDeletableEntityRepository<Question> questionsRepository;
        private readonly IDeletableEntityRepository<Answer> answersRepository;

        public SurveyService(
            IDeletableEntityRepository<Survey> surveysRepository,
            IDeletableEntityRepository<Question> questionsRepository,
            IDeletableEntityRepository<Answer> answersRepository)
        {
            this.surveysRepository = surveysRepository;
            this.questionsRepository = questionsRepository;
            this.answersRepository = answersRepository;
        }

        public async Task CreateAsync(CreateSurveyInputModel input, int idTarget)
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
                TargetSurveyId = idTarget,
            };

            foreach (var inputQuestion in input.Questions)
            {
                var isValidEnum = Enum.TryParse<QuestionType>(inputQuestion.QuestionType, out QuestionType qt);

                if (!isValidEnum)
                {
                    throw new Exception($"Invalid question type!");
                }

                if (survey.SampleFemale + survey.SampleMale != survey.SampleTotal)
                {
                    throw new Exception($"Invalid sample!");
                }

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

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var surveys = this.surveysRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<T>().ToList();
            return surveys;
        }

        public IEnumerable<T> GetAllOnePage<T>(string id)
        {
            var surveys = this.surveysRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .To<T>().ToList();
            return surveys;
        }

        public T GetById<T>(int id)
        {
            var survey = this.surveysRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return survey;
        }

        public int GetCount()
        {
            return this.surveysRepository.AllAsNoTracking().Count();
        }

        public async Task UpdateAsync(int id, EditSurveyInputModel input)
        {
            var survey = this.surveysRepository.All().FirstOrDefault(x => x.Id == id);
            survey.Name = input.Name;
            survey.Description = input.Description;
            survey.PointsStart = input.PointsStart;
            survey.PointsTotal = input.PointsTotal;
            survey.StartDate = input.StartDate;
            survey.EndDate = input.EndDate;
            survey.SampleTotal = input.SampleTotal;
            survey.SampleMale = input.SampleMale;
            survey.SampleFemale = input.SampleFemale;

            if (input.Questions.Count() > 0)
            {
                foreach (var inputQuestion in input.Questions)
                {
                    var isValidEnum = Enum.TryParse<QuestionType>(inputQuestion.QuestionType.ToString(), out QuestionType qt);

                    if (!isValidEnum)
                    {
                        throw new Exception($"Invalid question type!");
                    }

                    var currQ = this.questionsRepository.All().FirstOrDefault(x => x.Id == inputQuestion.Id);
                    currQ.Name = inputQuestion.Name;
                    currQ.QuestionType = inputQuestion.QuestionType;
                    foreach (var inputAnswer in inputQuestion.Answers)
                    {
                        var currA = this.answersRepository.All().FirstOrDefault(x => x.Id == inputAnswer.Id);
                        currA.Name = inputAnswer.Name;
                    }
                }
            }

            await this.surveysRepository.SaveChangesAsync();
            await this.questionsRepository.SaveChangesAsync();
            await this.answersRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var survey = this.surveysRepository.All().FirstOrDefault(x => x.Id == id);
            this.surveysRepository.Delete(survey);
            await this.surveysRepository.SaveChangesAsync();
        }
    }
}
