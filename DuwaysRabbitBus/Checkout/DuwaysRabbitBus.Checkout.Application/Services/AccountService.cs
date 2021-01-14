
using DuwaysRabbitBus.Checkout.Domain.Interfaces;
using DuwaysRabbitBus.Checkout.Domain.Models;
using DuwaysRabbitBus.Checkout.Application.Interfaces;
using System.Collections.Generic;
using DuwaysRabbitBus.Checkout.Application.Models;
using DuwaysRabbitBus.Checkout.Domain.Commands;
using DuwaysRabbitBus.Domain.Core.Bus;

namespace DuwaysRabbitBus.Checkout.Application.Services
{
    /**
     * Account Service class
     * 
     */
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Order(AccountOrder accountOrder)
        {
            var createOrderingCommand = new CreateOrderingCommand(
                accountOrder.AccountId,
                accountOrder.CourseId,
                accountOrder.Amount
            );

            _bus.SendCommand(createOrderingCommand);
        }
    }
}
