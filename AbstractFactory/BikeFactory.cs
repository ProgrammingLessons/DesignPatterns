using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // is a Bike factory
    public class BikeFactory : IVehicleFactory
    {
        // The object is produced when GetVehicle is called from the bike factory.
        public IVehicle GetVehicle()
        {
            return new Bike();
        }
    }
}
