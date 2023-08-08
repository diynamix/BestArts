namespace BestArts.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using Enums;

    [Comment("Orders")]
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            OrderItems = new HashSet<OrderItem>();
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

        [Comment("User Id")]
        [Required]
        public Guid UserId { get; set; }

        [Comment("User")]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Comment("Order status")]
        [Required]
        public OrderStatusType OrderStatus { get; set; }

        [Comment("Date of order")]
        [Required]
        public DateTime CreatedOn { get; set; }

        [Comment("Shipping address")]
        [Required]
        public string ShippingAddress { get; set; } = null!;

        [Comment("Shipping price")]
        [Required]
        public decimal ShippingPrice { get; set; }

        [Comment("Subtotal price")]
        [Required]
        public decimal SubTotalPrice { get; set; }

        [Comment("VAT")]
        [Required]
        public decimal VAT { get; set; }

        [Comment("Grand total price of order")]
        [Required]
        public decimal GrandTotalPrice { get; set; }

        [Comment("Payment method")]
        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        [Comment("Are terms accepted")]
        [Required]
        public bool TermsAccepted { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = null!;
    }
}