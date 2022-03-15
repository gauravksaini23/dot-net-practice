using Practice.BuilderPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.BuilderPattern.Provider
{
    public interface IVehicleBuilder
    {
        public Vehicle Vehicle { get; }
        void BuildFrame();
        void BuildEngine();
        void BuildWheels();
        void BuildDoors();
    }
}
