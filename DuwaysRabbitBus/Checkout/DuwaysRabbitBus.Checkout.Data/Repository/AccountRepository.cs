
using DuwaysRabbitBus.Checkout.Data.Context;
using DuwaysRabbitBus.Checkout.Domain.Interfaces;
using DuwaysRabbitBus.Checkout.Domain.Models;
using System.Collections.Generic;

namespace DuwaysRabbitBus.Checkout.Data.Repository
{

    /**
     * Account Repository class
     * 
     */ 
    public class AccountRepository : IAccountRepository
    {
        private readonly CheckoutDbContext _context;

        public AccountRepository(CheckoutDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
