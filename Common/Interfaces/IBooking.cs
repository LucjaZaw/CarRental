using CarRental.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces
{
    public interface IBooking
    {
        string PlateNumber { get; init; }
        IPerson Customer { get; init; }
        int KmRented { get; init; }
        int KmReturned { get; init; }
        int RentedAtDate { get; init; }
        int ReturnedAtDate { get; init; }
        int TotalCost { get; init; }
        VehicleStatuses VehicleStatus { get; init; }
    }
}
