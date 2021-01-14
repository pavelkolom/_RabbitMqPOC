
using DuwaysRabbitBus.Checkout.Application.Models;
using DuwaysRabbitBus.Checkout.Domain.Models;
using System.Collections.Generic;

namespace DuwaysRabbitBus.Checkout.Application.Interfaces
{
    /**
     * Account Service interface
     * 
     */ 
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Order(AccountOrder accountOrder);
    }
}
