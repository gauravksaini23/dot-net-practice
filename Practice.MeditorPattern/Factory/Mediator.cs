using Practice.MeditorPattern.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MeditorPattern.Factory
{
    public class Mediator : IMediator
    {
        Collegue1 _collegue1;
        Collegue2 _collegue2;

        public Collegue1 collegue1 { set { _collegue1 = value; } }
        public Collegue2 collegue2 { set { _collegue2 = value; } }
        public void Send(string message, ICollegue collegue)
        {
            if (collegue == _collegue1)
                _collegue2.Notify(message);
            else _collegue1.Notify(message);
        }
    }
}
