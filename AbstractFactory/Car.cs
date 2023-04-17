namespace AbstractFactory
{
    // The car class inherits from the IVehicle interface.
    public class Car : IVehicle
    {
        private readonly int Wheels;

        public Car()
        {
            Wheels = 4;
        }
        // The internals of the implemented methods are written.
        public int NumberOfWheels()
        {
            return Wheels;
        }

        public string VehicleType()
        {
            return "Car class";
        }
    }
}
