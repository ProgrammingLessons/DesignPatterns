using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class ChatroomMediator : IChatroomMediator
    {
        // Enrollees in Mediator
        private Dictionary<string, Participant> _participants = new();
        // Register to mediator
        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.ChatroomMediator = this;
        }

        // The method that receives a message to the mediator
        public void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];

            if (participant != null)
            {
                // send to recipient if user exists
                participant.Receive(from, message);
            }
        }
    }
}
