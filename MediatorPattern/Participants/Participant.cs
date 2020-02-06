using System;
using MediatorPattern.Chatroom;

namespace MediatorPattern.Participants
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public class Participant
    {
        public string Name { get; }

        // Gets chatroom
        public ChatroomMediator Chatroom { set; get; }

        public Participant(string name)
        {
            Name = name;
        }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive(
          string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
              from, Name, message);
        }
    }
}
