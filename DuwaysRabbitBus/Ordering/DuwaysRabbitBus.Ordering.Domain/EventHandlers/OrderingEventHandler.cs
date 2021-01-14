using DuwaysRabbitBus.Domain.Core.Bus;
using DuwaysRabbitBus.Ordering.Domain.Events;
using DuwaysRabbitBus.Ordering.Domain.Interfaces;
using DuwaysRabbitBus.Ordering.Domain.Models;
using System.Threading.Tasks;

namespace DuwaysRabbitBus.Ordering.Domain.EventHandlers
{

  /**
   * Ordering Event Handler class
   */
  public class OrderingEventHandler : IEventHandler<OrderingCreatedEvent>
  {
    private readonly IOrderingRepository _orderingRepository;

    public OrderingEventHandler(IOrderingRepository orderingRepository)
    {
      _orderingRepository = orderingRepository;
    }

    public Task Handle(OrderingCreatedEvent @event)
    {
      _orderingRepository.Add(new OrderingLog()
      {
        CourseId = @event.CourseId,
        AccountId = @event.AccountId,
        Amount = @event.Amount
      });

      return Task.CompletedTask;
    }
  }
}
