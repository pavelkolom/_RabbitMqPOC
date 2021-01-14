using MediatR;
using DuwaysRabbitBus.Checkout.Domain.Commands;
using DuwaysRabbitBus.Checkout.Domain.Events;
using DuwaysRabbitBus.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace DuwaysRabbitBus.Checkout.Domain.CommandHandlers
{
    /**
     * Ordering Command Handler class

     */ 
    public class OrderingCommandHandler : IRequestHandler<CreateOrderingCommand, bool>
    {
        private readonly IEventBus _bus;

        public OrderingCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateOrderingCommand request, CancellationToken cancellationToken)
        {
            // publish event to RabbitMQ
            _bus.Publish(new OrderingCreatedEvent(request.AccountId, request.CourseId, request.Amount));

            return Task.FromResult(true);
        }
    }
}
