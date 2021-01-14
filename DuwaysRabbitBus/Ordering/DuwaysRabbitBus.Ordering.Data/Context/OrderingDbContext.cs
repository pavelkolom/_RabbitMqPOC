using DuwaysRabbitBus.Ordering.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DuwaysRabbitBus.OrderingData.Context
{
    /**
     * Ordering Database Context

     */ 
    public class OrderingDbContext : DbContext
    {
        public OrderingDbContext(DbContextOptions options): base(options)
        { 
        }

        public DbSet<OrderingLog> OrderingLogs { get; set; }
    }
}
