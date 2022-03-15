using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.BuilderPattern.Factory
{
    public class Vehicle
    {
        string _vehicleType;
        Dictionary<string, string> _parts = new Dictionary<string, string>();
        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public void AddPart(string partName, string partSpecification)
        {
            if (!_parts.ContainsKey(partName))
            {
                _parts.Add(partName, partSpecification);
            }
        }

        public void Show()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Vehicle Type : {_vehicleType}");
            Console.WriteLine($"Frame : {_parts["frame"]}");
            Console.WriteLine($"Engine : {_parts["engine"]}");
            Console.WriteLine($"Wheels : {_parts["wheels"]}");
            Console.WriteLine($"Doors : {_parts["doors"]}");
        }
    }
}
