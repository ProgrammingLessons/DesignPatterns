using System;

namespace MediatorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mediator is defined
            ChatroomMediator chatroomMediator = new ChatroomMediator();

            // Participants are added
            Participant User1 = new ("User1");
            Participant User2 = new ("User2");
            Participant User3 = new ("User3");

            // participants are registered in the mediator
            chatroomMediator.Register(User1);
            chatroomMediator.Register(User2);
            chatroomMediator.Register(User3);

            // Participants send messages
            User1.Send("User2", "Hello");
            User2.Send("User1", "How are you?");
            User1.Send("User2", "can't complain");
            User3.Send("User2", "Awesome");
            
        }
    }
}
