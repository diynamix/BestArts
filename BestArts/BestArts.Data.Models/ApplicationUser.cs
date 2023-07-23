namespace BestArts.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.Wishlist = new HashSet<Wishlist>();
            this.Cart = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }

        public ICollection<Wishlist> Wishlist { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
