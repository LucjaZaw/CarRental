using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;

public interface IBooking
{
    IVehicle Vehicle { get; init; }
    IPerson Customer { get; init; }
    int KmRented { get; init; }
    int? KmReturned { get; }
    DateTime RentedAtDate { get; init; }
    DateTime? ReturnedAtDate { get; }
    int? TotalCost { get; }
    
}
