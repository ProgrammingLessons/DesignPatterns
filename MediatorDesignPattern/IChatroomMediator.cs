using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    // Mediator is defined
    public interface IChatroomMediator
    {
        public void Register(Participant participant);  
        public void Send(string from, string to, string message);
    }
}
