using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MeditorPattern.Provider
{
    public interface ICollegue
    {
        void Send(string message);
        void Notify(string message);
    }
}
