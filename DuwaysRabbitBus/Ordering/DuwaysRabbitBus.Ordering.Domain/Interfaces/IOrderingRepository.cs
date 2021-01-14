
using DuwaysRabbitBus.Ordering.Domain.Models;
using System.Collections.Generic;

namespace DuwaysRabbitBus.Ordering.Domain.Interfaces
{

  /**
   * Ordering Repository interface
   */
  public interface IOrderingRepository
    {
        IEnumerable<OrderingLog> GetOrderingLogs();
        void Add(OrderingLog orderingLog);
    }
}
