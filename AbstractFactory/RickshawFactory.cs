using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // is a Rickshaw factory
    public class RickshawFactory : IVehicleFactory
    {
        // The object is produced when GetVehicle is called from the Rickshaw factory.
        public IVehicle GetVehicle()
        {
            return new Rickshaw();
        }
    }
}
