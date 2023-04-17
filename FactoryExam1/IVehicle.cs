using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExam1
{
    // Interface definition is made for the vehicle.
    public interface IVehicle
    {
        // Two methods will be used in this interface
        string VehicleType();
        int NumberOfWheels();
    }
}
