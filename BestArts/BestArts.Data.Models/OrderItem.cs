namespace BestArts.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    [Comment("Order items")]
    public class OrderItem
    {
        [Comment("Order Id")]
        [Required]
        public Guid OrderId { get; set; }

        [Comment("Order")]
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        [Comment("Ordered product Id")]
        [Required]
        public Guid ProductId { get; set; }

        [Comment("Ordered product")]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Comment("Ordered product quantity")]
        [Required]
        public int Quantity { get; set; }

        [Comment("Ordered product single price")]
        [Required]
        public decimal SinglePrice { get; set; }

        [Comment("Ordered product total price")]
        [Required]
        public decimal TotalPrice { get; set; }
    }
}
