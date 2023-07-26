namespace BestArts.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using BestArts.Data.Models;
    using Interfaces;

    public class UserService : IUserService
    {
        private readonly BestArtsDbContext dbContext;

        public UserService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string> GetFirstNameByEmailAsync(string email)
        {
            ApplicationUser? user = await dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                return string.Empty;
            }

            return user.FirstName.ToString();
        }

        public async Task<string> GetLastNameByEmailAsync(string email)
        {
            ApplicationUser? user = await dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                return string.Empty;
            }

            return user.LastName.ToString();
        }

        public async Task<string> GetFullNameByEmailAsync(string email)
        {
            ApplicationUser? user = await dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                return string.Empty;
            }

            return $"{user.FirstName} {user.LastName}";
        }
    }
}