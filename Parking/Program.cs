using Parking.ParkingDestination;
using Parking.Vehicle;

namespace Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage NewGarage = new ParkingGarage();
            ParkingLot NewLot = new ParkingLot();

            Console.WriteLine($"Will a ParkingLot accommodate a Car? {NewLot.CanAccommodate(new Car())}");
            Console.WriteLine($"Will a ParkingLot accommodate a Motorcycle? {NewLot.CanAccommodate(new Motorcycle())}");
            Console.WriteLine($"Will a ParkingLot accommodate a Bus? {NewLot.CanAccommodate(new Bus())}");

            Console.WriteLine();

            Console.WriteLine($"Will a ParkingGarage accommodate a Car? {NewGarage.CanAccommodate(new Car())}");
            Console.WriteLine($"Will a ParkingGarage accommodate a Motorcycle? {NewGarage.CanAccommodate(new Motorcycle())}");
            Console.WriteLine($"Will a ParkingGarage accommodate a Bus? {NewGarage.CanAccommodate(new Bus())}");

            Console.ReadLine();
        }
    }
}
