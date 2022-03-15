using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MeditorPattern.Provider
{
    public interface IMediator
    {
        void Send(string message, ICollegue collegue);
    }
}
