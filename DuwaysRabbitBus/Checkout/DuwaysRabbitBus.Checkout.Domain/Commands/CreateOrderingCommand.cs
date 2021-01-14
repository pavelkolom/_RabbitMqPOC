
namespace DuwaysRabbitBus.Checkout.Domain.Commands
{
    /**
     * Create Transfer Command class
     * 
     */ 
    public class CreateOrderingCommand : OrderingCommand
    {
        public CreateOrderingCommand(int accountid, int courseid, decimal amount)
        {
            AccountId = accountid;
            CourseId = courseid;
            Amount = amount;
        }
    }
}
