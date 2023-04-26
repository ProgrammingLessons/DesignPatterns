using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    // Class of users who want to communicate with each other
    public class Participant
    {
        // Defines the control of messages
        public ChatroomMediator ChatroomMediator { get; set; }
        // user's name
        public string Name { get; set; }
        // Getting name when creating participant
        public Participant(string name)
        {
            Name = name;
        }

        // When sending a message, the user transmits the message and to whom it will be sent with the parameter.
        public void Send(string to, string message)
        {
            // Message is forwarded to mediator
            ChatroomMediator.Send(Name, to, message);
        }

        // Method that receives the message from the mediator
        public void Receive(string from,  string message)
        {
            Console.WriteLine($"{from} to {Name} : '{message}'");
        }


    }
}
