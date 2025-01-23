namespace Parking.Vehicle
{
    public class VehicleBase : IVehicle
    {
        public string Make { get; protected set; }
        public string Model { get; protected set; }
        public int NumberOfWheels { get; protected set; }
        public double Length { get; protected set; }
        public int Weight { get; protected set; }
        public int MaxNumberOfPassengers { get; protected set; }
        public bool IsCompact { get; }
    }
}
