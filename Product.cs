using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("brand")]
        public string? Brand { get; set; }

        [JsonPropertyName("costPrice")]
        public decimal CostPrice { get; set; }

        [JsonPropertyName("sellingPrice")]
        public decimal SellingPrice { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }
    }
}