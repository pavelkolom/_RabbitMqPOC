using DuwaysRabbitBus.Checkout.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DuwaysRabbitBus.Checkout.Data.Context
{
    /**
     * Checkout Database Context
     * 
     */ 
    public class CheckoutDbContext : DbContext
    {
        public CheckoutDbContext(DbContextOptions options): base(options)
        { 
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
