
using DuwaysRabbitBus.Ordering.Domain.Models;
using DuwaysRabbitBus.Ordering.Application.Interfaces;
using System.Collections.Generic;
using DuwaysRabbitBus.Ordering.Domain.Interfaces;

namespace DuwaysRabbitBus.Ordering.Application.Services
{
  /**
   * Ordering Service class
   */
  public class OrderingService : IOrderingService
  {
    private readonly IOrderingRepository _orderingRepository;

    public OrderingService(IOrderingRepository orderingRepository)
    {
      _orderingRepository = orderingRepository;
    }

    public IEnumerable<OrderingLog> GetTransferLogs()
    {
      return _orderingRepository.GetOrderingLogs();
    }
  }
}
