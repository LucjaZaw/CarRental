using CarRental.Common.Interfaces;
using CarRental.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Interfaces
{
    public interface IData
    {
        IEnumerable<IPerson> GetPersons();
        IEnumerable<IVehicle> GetVehicles();
        IEnumerable<IBooking> GetBookings();
    }
}
