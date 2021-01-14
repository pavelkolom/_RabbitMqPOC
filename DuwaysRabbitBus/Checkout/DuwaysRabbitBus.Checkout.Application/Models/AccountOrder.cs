
namespace DuwaysRabbitBus.Checkout.Application.Models
{
    /**
     * Account Order class
     * 
     */ 
    public class AccountOrder
    {
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public decimal Amount { get; set; }
    }
}
