namespace SayOnlinePanel.Services.Data
{
    using System.Threading.Tasks;

    using SayOnlinePanel.Web.ViewModels.Users;

    public interface IUsersService
    {
        T GetById<T>(int id);

        Task CompleteAsync(PeopleSelectionViewModel input, int id, string userId);
    }
}
