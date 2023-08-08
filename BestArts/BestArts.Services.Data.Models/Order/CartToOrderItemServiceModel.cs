using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BestArts.Services.Data.Models.Order
{
    public class CartToOrderItemServiceModel
    {
        public string ProductId { get; set; } = null!;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
