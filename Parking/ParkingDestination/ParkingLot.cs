using Parking.Vehicle;

namespace Parking.ParkingDestination
{
    public class ParkingLot: ParkingDestinationBase
    {
        public ParkingLot() 
        {
            // TODO: Initialize the properties for this particular parking destination


            // Parking lots do not have compact-only spots
            this.NumberOfCompactOnlySpots = 0;
        }

        public override bool CanAccommodate(IVehicle vehicle)
        {
            // Parking lots can accommodate any kind of vehicle
            return true;
        }

    }
}
