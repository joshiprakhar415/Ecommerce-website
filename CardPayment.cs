namespace Ecommerce.Models
{
    public class CardPayment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string ExpiryDate { get; set; } = string.Empty;
    }
}
