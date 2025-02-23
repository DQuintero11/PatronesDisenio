using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class User
    {
        protected IChatMediator _mediator;
        public string Name { get; }

        public User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message, User sender);
    }

}
