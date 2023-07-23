namespace BestArts.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    [Comment("Shopping cart")]
    public class Cart
    {
        [Comment("User Id")]
        [Required]
        public Guid UserId { get; set; }

        [Comment("User")]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Comment("Product in shopping cart Id")]
        [Required]
        public Guid ProductId { get; set; }

        [Comment("Product in shopping cart")]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Comment("Product quantity")]
        [Required]
        public int Quantity { get; set; }
    }
}
