namespace BestArts.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.User;

    [Comment("Custom application user")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();

            Wishlist = new HashSet<Wishlist>();
            Cart = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }

        [Comment("User first name")]
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Comment("User last name")]
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public ICollection<Wishlist> Wishlist { get; set; }

        public ICollection<Cart> Cart { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
