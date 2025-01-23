using Parking.Vehicle;

namespace Parking.ParkingDestination
{
    public class ParkingDestinationBase : IParkingDestination
    {
        public int NumberOfCompactOnlySpots { get; protected set; }
        public int NumberOfTotalSpots { get; protected set; }


        // TODO: Part of the implementation here will be to create a structure that stores the list
        //       of parking spots available in this destination.  A "ParkingSpot" class would have
        //       at least a unique identifier and a flag that said if it was a "Compact-Only" spot.
        //
        //       The NumberOf properties, then, would return a simple count of the number of
        //       spots in that structure, and we can get rid of the protected setters.


        // TODO: We probably want additional flags for AreThereAnyCompanyOnlySpotsAvailabe and
        //       AreThereAnySpotsAvailable, so we can tell when the destination is full.



        // This needs to be overridden in the implementing classes
        virtual public bool CanAccommodate(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }


        // This is the default implementation.  This can be overridden in lower classes
        virtual public int AssignParkingSpot(IVehicle vehicle)
        {
            // TODO: Implement the default algorithm:
            //
            //      If CanAccommodate(vehicle) returns false, then return 0 here.  This means there are no spots available that can accommodate this vehicle.
            //
            //      If vehicle.IsCompact is true, see if there are compact-only spots available.  If so, return the ID of the first available.
            //
            //      If vehicle.IsCompact is false, or if there are no compact-only spots available, see if there is a general spot available.  If so, return the ID of the first available.
            //
            //      Otherwise return 0.  This means there are no spots available that can accommodate this vehicle.


            throw new NotImplementedException();
        }
    }
}
