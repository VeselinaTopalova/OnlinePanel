namespace SayOnlinePanel.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SayOnlinePanel.Web.ViewModels.Vouchers;

    public interface IVouchersService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);

        T GetById<T>(int id);

        Task CreateAsync(CreateVoucherInputModel input);
    }
}
