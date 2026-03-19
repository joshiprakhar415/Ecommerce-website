namespace Ecommerce.Models
{
    public class CodPayment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Note { get; set; } = "Cash on Delivery";
    }
}
