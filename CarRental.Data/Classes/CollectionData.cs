using CarRental.Common.Classes;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        readonly List<IBooking> _bookings = new List<IBooking> {new Booking("RKO132", ),};
        public IEnumerable<IPerson> GetPersons() => _persons;

        public IEnumerable<IVehicle> GetVehicles()=> _vehicles;
        public IEnumerable<IBooking> GetBookings()=> _bookings;
    }
}
