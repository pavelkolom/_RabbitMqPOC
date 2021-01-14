using DuwaysRabbitBus.Checkout.Domain.Interfaces;
using DuwaysRabbitBus.Checkout.Application.Interfaces;
using DuwaysRabbitBus.Checkout.Application.Services;
using DuwaysRabbitBus.Checkout.Data.Context;
using DuwaysRabbitBus.Checkout.Data.Repository;
using DuwaysRabbitBus.Domain.Core.Bus;
using DuwaysRabbitBus.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using DuwaysRabbitBus.Checkout.Domain.Commands;
using DuwaysRabbitBus.Checkout.Domain.CommandHandlers;
using DuwaysRabbitBus.Ordering.Application.Interfaces;
using DuwaysRabbitBus.Ordering.Application.Services;
using DuwaysRabbitBus.Ordering.Data.Repository;
using DuwaysRabbitBus.Ordering.Domain.Interfaces;
using DuwaysRabbitBus.OrderingData.Context;
using DuwaysRabbitBus.Ordering.Domain.Events;
using DuwaysRabbitBus.Ordering.Domain.EventHandlers;

namespace DuwaysRabbitBus.Infra.IoC
{

    /**
     * Dependency Container class 
     */
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            // Subscriptions
            services.AddTransient<OrderingEventHandler>();

            // Domain Events
            services.AddTransient<IEventHandler<OrderingCreatedEvent>, OrderingEventHandler>();

            // Domain Checkout Commands
            services.AddTransient<IRequestHandler<CreateOrderingCommand, bool>, OrderingCommandHandler>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IOrderingService, OrderingService>();

            // Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IOrderingRepository, OrderingRepository>();
            services.AddTransient<CheckoutDbContext>();
            services.AddTransient<OrderingDbContext>();
        }
    }
}
