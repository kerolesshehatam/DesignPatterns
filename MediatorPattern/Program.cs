using System;
using MediatorPattern.Chatroom;
using MediatorPattern.Participants;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom
            ChatroomMediator chatroom = new ChatroomMediator();

            // Create participants and register them

            Participant Person1 = new Beatle("Person1");
            Participant Person2 = new Beatle("Person2");
            Participant Person3 = new Beatle("Person3");
            Participant Person4 = new Beatle("Person4");
            Participant Person = new NonBeatle("Person5");

            chatroom.Register(Person1);
            chatroom.Register(Person2);
            chatroom.Register(Person3);
            chatroom.Register(Person4);
            chatroom.Register(Person);

            // Chatting participants

            Person.Send("Person1", "Hi Perso1!");
            Person2.Send("Person3", "Hi Perso3!");
            Person3.Send("Person1", "Hi Perso1!");
            Person2.Send("Person2", "Hi Perso2!");
            Person4.Send("Person3", "Hi Perso3!");

            // Wait for user

            Console.ReadKey();
        }
    }
}
