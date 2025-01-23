using Parking.Vehicle;

namespace Parking.ParkingDestination
{
    public interface IParkingDestination
    {
        // Allow anything to read these properties, but only a descendant class to set them.
        int NumberOfCompactOnlySpots { get; }
        int NumberOfTotalSpots { get; }

        abstract bool CanAccommodate(IVehicle vehicle);
        abstract int AssignParkingSpot(IVehicle vehicle);
    }
}
