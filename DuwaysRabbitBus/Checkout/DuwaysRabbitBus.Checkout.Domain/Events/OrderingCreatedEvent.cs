using DuwaysRabbitBus.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuwaysRabbitBus.Checkout.Domain.Events
{
  /**
   * Ordering Created Event class
   */
  public class OrderingCreatedEvent : Event
  {
    public int AccountId { get; private set; }
    public int CourseId { get; private set; }
    public decimal Amount { get; private set; }

    public OrderingCreatedEvent(int accountid, int courseid, decimal amount)
    {
      AccountId = accountid;
      CourseId = courseid;
      Amount = amount;
    }
  }
}
