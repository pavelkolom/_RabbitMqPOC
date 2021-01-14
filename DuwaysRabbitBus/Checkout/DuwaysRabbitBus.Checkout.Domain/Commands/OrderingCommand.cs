using DuwaysRabbitBus.Domain.Core.Commands;

namespace DuwaysRabbitBus.Checkout.Domain.Commands
{
    /**
     * Transfer Command class
     */ 
    public class OrderingCommand : Command
    {
        public int AccountId { get; protected set; }
        public int CourseId { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
