using DuwaysRabbitBus.Domain.Core.Events;

namespace DuwaysRabbitBus.Ordering.Domain.Events
{
  /**
   * Ordering Created Event class
   */
  public class OrderingCreatedEvent : Event
  {
    public int CourseId { get; private set; }
    public int AccountId { get; private set; }
    public decimal Amount { get; private set; }

    public OrderingCreatedEvent(int accountid, int courseid,  decimal amount)
    {
      CourseId = courseid;
      AccountId = accountid;
      Amount = amount;
    }
  }
}
