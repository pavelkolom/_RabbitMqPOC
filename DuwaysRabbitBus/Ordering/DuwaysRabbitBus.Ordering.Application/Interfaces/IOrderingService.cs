
using DuwaysRabbitBus.Ordering.Domain.Models;
using System.Collections.Generic;

namespace DuwaysRabbitBus.Ordering.Application.Interfaces
{
  /**
   * Ordering Service interface
   */
  public interface IOrderingService
    {
        IEnumerable<OrderingLog> GetTransferLogs();
    }
}
