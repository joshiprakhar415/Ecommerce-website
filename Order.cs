using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Order
    {
        public int Id { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("orderDate")]
        public DateTime OrderDate { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }

        [JsonPropertyName("deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("items")]
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
