namespace BestArts.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

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
        public string Product { get; set; } = null!;

        [Comment("Ordered product quantity")]
        [Required]
        public int Quantity { get; set; }

        [Comment("Ordered product total price")]
        [Required]
        public decimal TotalPrice { get; set; }
    }
}
