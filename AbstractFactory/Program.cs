using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The object is produced from the bike factory.
            BikeFactory bikeFactory = new BikeFactory();
            // A new bike instance is created from the factory with GetVehicle.
            var bike = bikeFactory.GetVehicle();

            // The object is produced from the car factory.
            CarFactory carFactory = new CarFactory();
            // A new car instance is created from the factory with GetVehicle.
            var car = carFactory.GetVehicle();

            // The object is produced from the rickshaw factory.
            RickshawFactory rickshawFactory = new RickshawFactory();
            // A new rickshaw instance is created from the factory with GetVehicle.
            var rickshaw = rickshawFactory.GetVehicle();

            
        }
    }
}
