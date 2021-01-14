
using DuwaysRabbitBus.Ordering.Domain.Interfaces;
using DuwaysRabbitBus.Ordering.Domain.Models;
using DuwaysRabbitBus.OrderingData.Context;
using System.Collections.Generic;

namespace DuwaysRabbitBus.Ordering.Data.Repository
{

  /**
   * Ordering Repository class
   */
  public class OrderingRepository : IOrderingRepository
    {
        private readonly OrderingDbContext _context;

        public OrderingRepository(OrderingDbContext context)
        {
            _context = context;
        }

        public void Add(OrderingLog orderingLog)
        {
            _context.OrderingLogs.Add(orderingLog);
            _context.SaveChanges();
        }

        public IEnumerable<OrderingLog> GetOrderingLogs()
        {
            return _context.OrderingLogs;
        }
    }
}
