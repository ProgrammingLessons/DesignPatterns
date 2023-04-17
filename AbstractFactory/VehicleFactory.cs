using System;

namespace AbstractFactory
{
    public interface IVehicleFactory
    {
        // Factory class for vehicle class
        // The class must have used the IVehicle interface.
        public IVehicle GetVehicle();
    }
}
