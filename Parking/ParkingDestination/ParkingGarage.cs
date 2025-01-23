using Parking.Vehicle;

namespace Parking.ParkingDestination
{
    public class ParkingGarage : ParkingDestinationBase
    {
        public ParkingGarage()
        {
            // TODO: Initialize the properties for this particular parking destination
        }

        public override bool CanAccommodate(IVehicle vehicle)
        {
            // Parking garages can accommodate anything except busses
            if (vehicle.GetType().Equals(typeof(Bus))) { return false; }
            return true;
        }

    }
}
