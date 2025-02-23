using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ChatUser : User
    {
        public ChatUser(IChatMediator mediator, string name) : base(mediator, name) { }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"📤 {Name} envía: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message, User sender)
        {
            Console.WriteLine($"📩 {Name} recibe de {sender.Name}: {message}");
        }
    }

