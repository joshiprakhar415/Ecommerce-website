using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Shopping
    {
        public int Id { get; set; }

        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("itemType")]
        public string ItemType { get; set; } = "Cart"; // "Cart" or "Wishlist"

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; } = 1;

        [JsonPropertyName("productName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("orderDate")]
        public DateTime OrderDate { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
