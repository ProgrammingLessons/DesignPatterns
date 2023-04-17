using System;

namespace FactoryExam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We specify which class we want to create from the VehicleFactory class to the GetVehicle method.
            var bike = VehicleFactory.GetVehicle("bike");
            var car = VehicleFactory.GetVehicle("car");
            var rickshaw = VehicleFactory.GetVehicle("rickshaw");
            var bus = VehicleFactory.GetVehicle("bus");
        }
    }
}
