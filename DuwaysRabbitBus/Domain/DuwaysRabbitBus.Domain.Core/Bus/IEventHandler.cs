using DuwaysRabbitBus.Domain.Core.Events;
using System.Threading.Tasks;

namespace DuwaysRabbitBus.Domain.Core.Bus
{
    /**
     * Event Handler interface 
     * 
     */ 
    
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
