namespace Parking.Vehicle
{
    public class VehicleBase : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public double Length { get; set; }
        public int Weight { get; set; }
        public int MaxNumberOfPassengers { get; set; }

        public bool IsCompact 
        { 
            get
            {
                return this.Weight < 1500;
            }
        }
    }
}
