using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // is a Car factory
    public class CarFactory : IVehicleFactory
    {
        // The object is produced when GetVehicle is called from the Car factory.
        public IVehicle GetVehicle()
        {
            return new Car();
        }
    }
}
