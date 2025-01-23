namespace Parking.Vehicle
{
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int NumberOfWheels { get; set; }
        double Length { get; set; }
        int Weight { get; set; }
        int MaxNumberOfPassengers { get; set; }

        bool IsCompact { get; }
    }
}
