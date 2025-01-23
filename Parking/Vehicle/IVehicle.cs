namespace Parking.Vehicle
{
    public interface IVehicle
    {
        // Allow anything to read these properties, but only a descendant class to set them.
        string Make { get; }
        string Model { get; }
        int NumberOfWheels { get; }
        double Length { get; }
        int Weight { get; }
        int MaxNumberOfPassengers { get; }

        // TODO: This could be a standalone property, or we could try to define it in terms of the Length/Weight properties
        bool IsCompact { get; }
    }
}
