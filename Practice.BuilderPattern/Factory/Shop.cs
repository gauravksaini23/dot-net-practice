using Practice.BuilderPattern.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.BuilderPattern.Factory
{
    public class Shop
    {
        public void Construct(IVehicleBuilder vehicleBuilder) 
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
