

using DuwaysRabbitBus.Checkout.Domain.Models;
using System.Collections.Generic;

namespace DuwaysRabbitBus.Checkout.Domain.Interfaces
{

    /**
     * Account Repository interface
     * 
     */ 
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
