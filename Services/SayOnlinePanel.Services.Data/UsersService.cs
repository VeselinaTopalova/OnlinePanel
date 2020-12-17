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
            throw new NotImplementedException();
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
