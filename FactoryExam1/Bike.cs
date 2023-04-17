using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExam1
{
    // The bike class inherits from the IVehicle interface.
    public class Bike : IVehicle
    {
        private readonly int Wheels;

        public Bike()
        {
            Wheels = 2;
        }
        // The internals of the implemented methods are written.
        public int NumberOfWheels()
        {
            return Wheels;
        }

        public string VehicleType()
        {
            return "Bike class";
        }
    }
}
