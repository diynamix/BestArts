namespace BestArts.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetFirstNameByEmailAsync(string email);
        Task<string> GetLastNameByEmailAsync(string email);
        Task<string> GetFullNameByEmailAsync(string email);
    }
}
