namespace SayOnlinePanel.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
        private readonly IDeletableEntityRepository<Voucher> voucherRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public UserInfosService(IDeletableEntityRepository<UserInfo> userInfosRepository,
            IDeletableEntityRepository<Survey> surveysRepository,
            IDeletableEntityRepository<TargetSurvey> targetSurveysRepository,
            IDeletableEntityRepository<Voucher> voucherRepository,
            UserManager<ApplicationUser> userManager)
        {
            this.userInfosRepository = userInfosRepository;
            this.surveysRepository = surveysRepository;
            this.targetSurveysRepository = targetSurveysRepository;
            this.voucherRepository = voucherRepository;
            this.userManager = userManager;
        }

        public SyrveysListViewModel GetUsersPoints (string id)
        {
            //var userVM = this.userInfosRepository.All().Where(x => x.UserId == id).Select(x => new SyrveysListViewModel
            //{
            //    Points = x.Points,
            //    Surveys = x.SurveyUserInfos
            //    .Select(s => new SurveysNamePoints
            //    {
            //        Name = s.Survey.Name,
            //        Points = s.isComplete == true ? s.Survey.PointsTotal : s.Survey.PointsStart,
            //        Date = s.Survey.ModifiedOn.HasValue ? s.Survey.ModifiedOn.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) : null,
            //    })
            //}).FirstOrDefault();
            //return userVM;
            throw new NotImplementedException();
        }

        public int GetUsersPointsForVoucher(string id)
        {
            var points = this.userInfosRepository.All().Where(x => x.UserId == id).FirstOrDefault().Points;
            return points;
        }

        public List<Voucher> GetUsersVoucher(string id)
        {
            //var userVauchers = this.userInfosRepository.All().Where(x => x.UserId == id).FirstOrDefault()
            //    .VoucherUsers
            //    .Select(s => s.Voucher).ToList();

            //return userVauchers;
            throw new NotImplementedException();

        }

        public async Task BuyVouchers(string userId, int voucherId)
        {
            //var userInfo = this.userInfosRepository.All().FirstOrDefault(x => x.UserId == userId);
            //var voucher = this.voucherRepository.All().Where(x => x.Id == voucherId).FirstOrDefault();
            //if(userInfo.Points >= voucher.Points)
            //{
            //    var voucherUser = new VoucherUser
            //    {
            //        VoucherId = voucher.Id,
            //        UserInfoId = userInfo.Id,
            //    };
            //    userInfo.VoucherUsers.Add(voucherUser);
            //    userInfo.Points -= voucher.Points;
            //}
            //this.userInfosRepository.SaveChangesAsync();
            throw new NotImplementedException();
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
                Gender = resultGender,
                Birthday = input.Birthday,
                Town = resultTown,
            };
            await this.userInfosRepository.AddAsync(userInfo);
            await this.userInfosRepository.SaveChangesAsync();
        }

        public IEnumerable<Survey> GetSurveysForUser(string userId)
        {
            var userInfo = this.userInfosRepository.All().FirstOrDefault(x => x.UserId == userId);
            var surveysForUser = new List<Survey>();
            if (userInfo.Gender == Gender.Male)
                {
                    surveysForUser = this.surveysRepository.All()
                 .OrderByDescending(x => x.Id)
                 .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now
                     && w.SampleMale > 0 && w.SampleMale > w.SampleMaleComplete)
                 .Include(x => x.TargetSurvey)
                 .ThenInclude(x => x.TargetSyrveyUserInfos)
                 .ToList();
                }
            else if (userInfo.Gender == Gender.Female)
                {
                    surveysForUser = this.surveysRepository.All()
                .OrderByDescending(x => x.Id)
                .Where(w => w.StartDate < DateTime.Now && w.EndDate > DateTime.Now
                    && w.SampleFemale > 0 && w.SampleFemale > w.SampleFemaleComplete)
                .Include(x => x.TargetSurvey)
                .ThenInclude(x => x.TargetSyrveyUserInfos)
                .ToList();
                }

            for (int i = 0; i < surveysForUser.Count; i++)
                {
                    var TSUI = surveysForUser[i].TargetSurvey.TargetSyrveyUserInfos.Where(x => x.TargetSurveyId == surveysForUser[i].TargetSurveyId && x.UserInfoId == userInfo.Id).FirstOrDefault();
                    if (surveysForUser[i].TargetSurvey.TargetSyrveyUserInfos.Contains(TSUI))
                    {
                        surveysForUser.Remove(surveysForUser[i]);
                    }
                }

            return surveysForUser;
        }
    }
}
