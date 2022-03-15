using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MediatorPattern.MultipleParticipants.Provider
{
    public interface IParticipant
    {
        void Send(string to, string message);
        void Receive(string from, string message);
    }
}
