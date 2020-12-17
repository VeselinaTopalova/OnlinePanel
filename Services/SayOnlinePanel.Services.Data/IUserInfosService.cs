namespace SayOnlinePanel.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Web.ViewModels.UserInfos;

    public interface IUserInfosService
    {
        Task CreateAsync(CreateUserInfoInputModel input, string id);

        SyrveysListViewModel GetUsersPoints(string id);

        IEnumerable<Survey> GetSurveysForUser(string userId);

        int GetUsersPointsForVoucher(string id);

        List<Voucher> GetUsersVoucher(string id);

        Task BuyVouchers(string userId, int voucherId);
    }
}
