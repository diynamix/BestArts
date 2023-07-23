namespace BestArts.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static Common.EntityValidationConstants.Category;

    [Comment("Categories for the products")]
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Comment("Primary key")]
        [Key]
        public int Id { get; set; }

        [Comment("Category name")]
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public ICollection<Product> Products { get; set; } = null!;
    }
}