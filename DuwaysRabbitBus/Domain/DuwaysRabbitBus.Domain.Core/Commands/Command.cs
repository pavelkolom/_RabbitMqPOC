
using DuwaysRabbitBus.Domain.Core.Events;
using System;

namespace DuwaysRabbitBus.Domain.Core.Commands
{

    /**
     * Command class
     * 
     */ 
    public abstract class Command : Message 
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
