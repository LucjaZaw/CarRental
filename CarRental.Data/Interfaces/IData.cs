using CarRental.Common.Interfaces;

namespace CarRental.Data.Interfaces
{
    public interface IData
    {
        IEnumerable<IPerson> GetPersons();
        IEnumerable<IVehicle> GetVehicles();
        IEnumerable<IBooking> GetBookings();
    }
}
