using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Data.Classes
{
    public class CollectionData : IData
    {
        readonly List<IPerson> _persons = new List<IPerson> 
        {new Custumer ("Lucja", "Zawiasa", 000318),
        new Custumer("Tobias", "Lindius", 010514)};
        readonly List<IVehicle> _vehicles = new List<IVehicle>
        {new Car("RKO132", "Volkswagen", 4000, 70.0, 400.0, Common.Enums.VehicleTypes.Golf, Common.Enums.VehicleStatuses.Available),
        new Car("ABC123", "Volkswagen", 2500, 50.0, 600.0, Common.Enums.VehicleTypes.Polo, Common.Enums.VehicleStatuses.Available),
        new Car("DEF456", "Volkswagen", 8000, 100.0, 300.0, Common.Enums.VehicleTypes.Passat, Common.Enums.VehicleStatuses.Unavailable),
        new Car("GHI789", "Citroen", 10000, 150.0, 400.0, Common.Enums.VehicleTypes.Van, Common.Enums.VehicleStatuses.Available),
        new Car("JKL123", "Yamaha", 0, 250.0, 1000.0, Common.Enums.VehicleTypes.Motorcycle, Common.Enums.VehicleStatuses.Unavailable)};
        readonly List<IBooking> _bookings;
        public CollectionData()
        {
            _bookings = new List<IBooking> 
            {new Booking("RKO132", _persons.Single(p => p.SocialSecNum == 000318), 3700, 4000, DateTime.Now, DateTime.Now.AddDays(1),21400, VehicleStatuses.Available),
            new Booking("DEF456", _persons.Single(p => p.SocialSecNum == 000318), 8000, null, DateTime.Now, null, null, VehicleStatuses.Unavailable),
            new Booking("JKL123", _persons.Single(p => p.SocialSecNum == 010514), 0, null, DateTime.Now, null, null, VehicleStatuses.Unavailable)};
        }
        
        public IEnumerable<IPerson> GetPersons() => _persons;
        public IEnumerable<IVehicle> GetVehicles()=> _vehicles;
        public IEnumerable<IBooking> GetBookings()=> _bookings;
    }
}
