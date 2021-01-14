using DuwaysRabbitBus.Domain.Core.Commands;
using DuwaysRabbitBus.Domain.Core.Events;
using System.Threading.Tasks;

namespace DuwaysRabbitBus.Domain.Core.Bus
{
    /**
     * Event Bus interface
     * 
     */ 
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
