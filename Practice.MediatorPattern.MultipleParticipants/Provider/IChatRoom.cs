using Practice.MediatorPattern.MultipleParticipants.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MediatorPattern.MultipleParticipants.Provider
{
    public interface IChatRoom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}
