namespace AbstractFactory
{
    // The rickshaw class inherits from the IVehicle interface.
    public class Rickshaw : IVehicle
    {
        private readonly int Wheels;

        public Rickshaw()
        {
            Wheels = 3;
        }
        // The internals of the implemented methods are written.
        public int NumberOfWheels()
        {
            return Wheels;
        }

        public string VehicleType()
        {
            return "Rickshaw class";
        }
    }
}
