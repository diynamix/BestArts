namespace BestArts.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    [Comment("Wishlist")]
    public class Wishlist
    {
        [Comment("User Id")]
        [Required]
        public Guid UserId { get; set; }

        [Comment("User")]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Comment("Product in wishlist Id")]
        [Required]
        public Guid ProductId { get; set; }

        [Comment("Product in wishlist")]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
