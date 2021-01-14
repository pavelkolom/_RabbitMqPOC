using MediatR;

namespace DuwaysRabbitBus.Domain.Core.Events
{
    /**
     * Event Message class
     * 
     */ 
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
