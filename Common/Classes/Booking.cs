using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public string PlateNumber { get; init; }
    public IPerson Customer { get; init; }
    public int KmRented { get; init; }
    public int? KmReturned { get; init; }
    public DateTime RentedAtDate { get; init; }
    public DateTime? ReturnedAtDate { get; init; }
    public int? TotalCost { get; init; }
    public VehicleStatuses VehicleStatus { get; init; }

    public Booking(string plateNumber, IPerson customer, int kmRented, 
        int? kmReturned, DateTime rentedAtDate, DateTime? returnedAtDate, int? totalCost, VehicleStatuses vehicleStatus) =>
        (PlateNumber, Customer, KmRented, KmReturned, RentedAtDate, ReturnedAtDate, TotalCost, VehicleStatus) = 
        (plateNumber, customer, kmRented, kmReturned, rentedAtDate, returnedAtDate, totalCost, vehicleStatus);
}
