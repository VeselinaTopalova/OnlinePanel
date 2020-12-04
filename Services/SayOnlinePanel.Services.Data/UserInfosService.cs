namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;
    using SayOnlinePanel.Web.ViewModels.UserInfos;
    using Gender = SayOnlinePanel.Data.Models.Gender;
    using Town = SayOnlinePanel.Data.Models.Town;

    public class UserInfosService : IUserInfosService
    {
        private readonly IDeletableEntityRepository<UserInfo> userInfosRepository;
        private readonly IDeletableEntityRepository<Survey> surveysRepository;

        public UserInfosService(IDeletableEntityRepository<UserInfo> userInfosRepository, IDeletableEntityRepository<Survey> surveysRepository)
        {
            this.userInfosRepository = userInfosRepository;
            this.surveysRepository = surveysRepository;
        }


        public IEnumerable<T> GetSurveysForUser<T>(string id)
        {
            var surveys = this.surveysRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .To<T>().ToList();
            return surveys;
            //var user = userInfosRepository.AllAsNoTracking().Where(w => w.UserId == id).FirstOrDefault();
            //var gender = user.Gender;
            //var surveys = new List<T>();
            //if (gender == "male")
            //{
            //    surveys = this.surveysRepository.AllAsNoTracking()
            //    .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now &&
            //    w.SampleMaleComplete < w.SampleMale)
            //    .OrderByDescending(x => x.Id)
            //    .To<T>().ToList();
            //}
            //else if  (gender == "female")
            //{
            //    surveys = this.surveysRepository.AllAsNoTracking()
            //    .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now &&
            //    w.SampleFemaleComplete < w.SampleFemale)
            //    .OrderByDescending(x => x.Id)
            //    .To<T>().ToList();
            //}
            //return surveys;
        }

        public async Task CreateAsync(CreateUserInfoInputModel input, string id)
        {
            bool isValidEnum = true;

            var g = Enum.TryParse<Gender>(input.Gender.ToString(), out Gender test);

            if (!g)
            {
                isValidEnum = false;
                //???
                
            }
            var userInfo = new UserInfo
            {
                UserId = id,
                Gender = Enum.Parse<Gender>(input.Gender.ToString()),
                Birthday = input.Birthday,
                Town = Enum.Parse<Town>(input.Town.ToString()),
            };
            await this.userInfosRepository.AddAsync(userInfo);
            await this.userInfosRepository.SaveChangesAsync();
        }

    }
}
