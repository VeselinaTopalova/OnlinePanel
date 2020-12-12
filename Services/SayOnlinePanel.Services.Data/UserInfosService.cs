namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
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
        private readonly IDeletableEntityRepository<TargetSurvey> targetSurveysRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public UserInfosService(IDeletableEntityRepository<UserInfo> userInfosRepository, 
            IDeletableEntityRepository<Survey> surveysRepository,
            IDeletableEntityRepository<TargetSurvey> targetSurveysRepository, UserManager<ApplicationUser> userManager)
        {
            this.userInfosRepository = userInfosRepository;
            this.surveysRepository = surveysRepository;
            this.targetSurveysRepository = targetSurveysRepository;
            this.userManager = userManager;
        }


        public IEnumerable<Survey> GetSurveysForUser(string userId)
        {
            //var surveys = this.surveysRepository.AllAsNoTracking()
            //    .OrderByDescending(x => x.Id)
            //    .To<T>().ToList();
            //return surveys;
            var userInfo = this.userInfosRepository.All().FirstOrDefault(x => x.UserId == userId);
            
            if (userInfo.Gender == Gender.Male)
            {
                //List<Survey> surveysForUser = this.surveysRepository.All()
                //.OrderByDescending(x => x.Id)
                //.Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now 
                //    && w.SampleMale > 0
                //    //&& !w.Users.Contains(userInfo.User)
                //    )
                ////.Select(s => s.TargetSurvey)
                //.Include(x => x.TargetSurvey)
                //.ThenInclude(x => x.TargetSyrveyUserInfos)
                ////.To<T>()
                //.ToList();

                var surveysForUser = this.surveysRepository.All()
                .OrderByDescending(x => x.Id)
                .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now
                    && w.SampleMale > 0)
                .ToList();

                //foreach (var item in surveysForUser)
                //{
                //    var TSUI = item.TargetSurvey.TargetSyrveyUserInfos.Where(x => x.TargetSurveyId == item.TargetSurveyId && x.UserInfoId == userInfo.Id).FirstOrDefault();
                //    if (item.TargetSurvey.TargetSyrveyUserInfos.Contains(TSUI))
                //    {
                //        surveysForUser.Remove(item);
                //    }
                //}
                for (int i = 0; i < surveysForUser.Count; i++)
                {
                    var TSUI = surveysForUser[i].TargetSurvey.TargetSyrveyUserInfos.Where(x => x.TargetSurveyId == surveysForUser[i].TargetSurveyId && x.UserInfoId == userInfo.Id).FirstOrDefault();
                    if (surveysForUser[i].TargetSurvey.TargetSyrveyUserInfos.Contains(TSUI))
                    {
                        surveysForUser.Remove(surveysForUser[i]);
                    }
                }
                //foreach (var item in surveysForUser)
                //{
                //    var surveysForUserR = this.surveysRepository.All()
                //.OrderByDescending(x => x.Id)
                //.Where(w => w.Id == item.Id)
                //.Select(s => s.TargetSurvey)
                //.To<T>()
                //.ToList();
                //}
                return surveysForUser;
            }
            else
            {
                var surveysForUser = this.surveysRepository.All()
                .OrderByDescending(x => x.Id)
                .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now
                    && w.SampleFemale > 0
                    //&& !w.Users.Contains(userInfo.User)
                    )
                //.Select(s => s.TargetSurvey)
                .Include(x => x.TargetSurvey)
                .ThenInclude(x => x.TargetSyrveyUserInfos)
                //.To<T>()
                .ToList();
                foreach (var item in surveysForUser)
                {
                    var TSUI = item.SurveyUserInfos.Where(x => x.SurveyId == item.Id && x.UserInfoId == userInfo.Id).FirstOrDefault();
                    if (item.SurveyUserInfos.Contains(TSUI))
                    {
                        surveysForUser.Remove(item);
                    }
                }
                return surveysForUser;
            }

        }

        public async Task CreateAsync(CreateUserInfoInputModel input, string id)
        {

            var isValidEnumGender = Enum.TryParse<Gender>(input.Gender.ToString(), out Gender resultGender);
            var isValidEnumTown = Enum.TryParse<Town>(input.Town.ToString(), out Town resultTown);

            if (!isValidEnumGender || !isValidEnumTown)
            {
                throw new Exception("Gender isn't valid!");
            }

            var userInfo = new UserInfo
            {
                UserId = id,
                //Gender = Enum.Parse<Gender>(input.Gender.ToString()),
                Gender = resultGender,
                Birthday = input.Birthday,
                Town = resultTown,
                //Town = Enum.Parse<Town>(input.Town.ToString()),
            };
            await this.userInfosRepository.AddAsync(userInfo);
            await this.userInfosRepository.SaveChangesAsync();
        }

    }
}
