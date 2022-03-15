using Practice.MediatorPattern.MultipleParticipants.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MediatorPattern.MultipleParticipants.Factory
{
    public class Participant : IParticipant
    {
        readonly string _name;
        IChatRoom? _chatRoom;
        public string Name { get { return _name; } }
        public IChatRoom ChatRoom { set { _chatRoom = value; } }
        public Participant(string name)
        {
            _name = name;
        }

        public void Send(string to, string message)
        {
            _chatRoom?.Send(_name, to, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {_name} : '{message}'");
        }
    }
}
