using SayOnlinePanel.Data.Models;
using SayOnlinePanel.Web.ViewModels.UserInfos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SayOnlinePanel.Services.Data
{
    public interface IUserInfosService
    {
        Task CreateAsync(CreateUserInfoInputModel input, string id);

        IEnumerable<Survey> GetSurveysForUser(string userId);
    }
}
