namespace BestArts.Data.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Product;

    [Comment("Products")]
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }

        [Comment("Primary key")]
        [Key]
        public Guid Id { get; set; }

        [Comment("Product name")]
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Product image URL")]
        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Comment("Product category ID")]
        [Required]
        public int CategoryId { get; set; }

        [Comment("Product category")]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Comment("Product width")]
        [Required]
        public decimal Width { get; set; }

        [Comment("Product height")]
        [Required]
        public decimal Height { get; set; }

        [Comment("Product price")]
        [Required]
        public decimal Price { get; set; }

        //[Comment("Product discounted price")]
        //[Required]
        //public decimal? DiscountedPrice { get; set; }

        [Comment("Date and time created on")]
        [Required]
        public DateTime CreatedOn { get; set; }

        [Comment("Is the product deleted")]
        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set;}

        [Comment("Date and time deleted on")]
        public DateTime? DeletedOn { get; set; }
    }
}
