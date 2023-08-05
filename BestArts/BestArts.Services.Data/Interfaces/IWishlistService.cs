namespace BestArts.Services.Data.Interfaces
{
    public interface IWishlistService
    {
        Task<bool> IsAlreadyAddedAsync(string userId, string productId);
    }
}
