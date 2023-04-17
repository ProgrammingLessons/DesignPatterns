using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExam1
{
    public class VehicleFactory
    {
        // Factory class for vehicle class
        // The GetVehicle method creates the requested class.
        // The class must have used the IVehicle class.
        public static IVehicle GetVehicle(string type)
        {
            IVehicle vehicle = null;
            // It gets which class to create in the method parameter.
            // It is created according to the type parameter.
            if (type.ToLower().Equals("bike"))
            {
                vehicle = new Bike();
            }
            else if (type.ToLower().Equals("car"))
            {
                vehicle = new Car();
            }
            else if (type.ToLower().Equals("rickshaw"))
            {
                vehicle = new Rickshaw();
            }
            else
            {
                // If it does not meet any conditions, we state that it is incorrect.
                throw new Exception("It is not a valid model.");
            }
            return vehicle; 
        }
    }
}
