using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [JsonPropertyName("orderId")]
        public int OrderId { get; set; }

        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("productName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
