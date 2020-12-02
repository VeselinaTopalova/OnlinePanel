namespace SayOnlinePanel.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;

    public class UserInfosService //: IUserInfosService
    {
        private readonly IDeletableEntityRepository<UserInfo> userInfosRepository;
        private readonly IDeletableEntityRepository<Survey> surveysRepository;

        public UserInfosService(IDeletableEntityRepository<UserInfo> userInfosRepository, IDeletableEntityRepository<Survey> surveysRepository)
        {
            this.userInfosRepository = userInfosRepository;
            this.surveysRepository = surveysRepository;
        }

        

    }
}
