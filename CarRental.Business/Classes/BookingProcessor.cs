using CarRental.Common.Classes;
using CarRental.Common.Interfaces;
using CarRental.Data.Classes;
using CarRental.Data.Interfaces;

namespace CarRental.Business.Classes
{
    public class BookingProcessor
    {
        IData _data;
        public BookingProcessor(IData data) => _data = data;

        public IEnumerable<IPerson> PersonData() => _data.GetPersons();
        public IEnumerable<IBooking> BookingData() => _data.GetBookings();
        public IEnumerable<IVehicle> VehicleData() => _data.GetVehicles();

        
    }
}
