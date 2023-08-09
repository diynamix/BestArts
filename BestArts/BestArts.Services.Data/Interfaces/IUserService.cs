using BestArts.Web.ViewModels.User;

namespace BestArts.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetFullNameByEmailAsync(string email);

        Task<string> GetFullNameByIdAsync(string id);

        Task<IEnumerable<UserViewModel>> AllAsync();
    }
}
