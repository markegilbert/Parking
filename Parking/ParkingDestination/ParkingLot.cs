using Parking.Vehicle;

namespace Parking.ParkingDestination
{
    public class ParkingLot: ParkingDestinationBase
    {
        public ParkingLot() 
        {
            // TODO: Initialize the properties for this particular parking destination
        }

        public override bool CanAccommodate(IVehicle vehicle)
        {
            // Parking lots can accommodate any kind of vehicle
            return true;
        }

    }
}
