using Practice.BuilderPattern.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.BuilderPattern.Factory
{
    public class MotorCycleBuilder : IVehicleBuilder
    {
        Vehicle _vehicle;
        public MotorCycleBuilder()
        {
            _vehicle = new Vehicle("Motor Cycle");
        }

        public Vehicle Vehicle => _vehicle;

        public void BuildDoors()
        {
            _vehicle.AddPart("doors", "No doors");
        }

        public void BuildEngine()
        {
            _vehicle.AddPart("engine", "125 cc");
        }

        public void BuildFrame()
        {
            _vehicle.AddPart("frame", "Motor cycle frame");
        }

        public void BuildWheels()
        {
            _vehicle.AddPart("wheels", "2");
        }
    }
}
