using SayOnlinePanel.Web.ViewModels.UserInfos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SayOnlinePanel.Services.Data
{
    public interface IUserInfosService
    {
        IEnumerable<T> GetSurveysForUser<T>(string id);

        Task CreateAsync(CreateUserInfoInputModel input, string id);
    }
}
