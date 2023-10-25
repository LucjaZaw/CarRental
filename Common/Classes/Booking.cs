using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle Vehicle { get; init; }
    public IPerson Customer { get; init; }
    public int KmRented { get; init; }
    public int? KmReturned { get; init; }
    public DateTime RentedAtDate { get; init; }
    public DateTime? ReturnedAtDate { get; init; }
    public int? TotalCost => CalcTotal();

    public Booking(IVehicle vehicle, IPerson customer, int kmRented, 
        int? kmReturned, DateTime rentedAtDate, DateTime? returnedAtDate) =>
        (Vehicle, Customer, KmRented, KmReturned, RentedAtDate, ReturnedAtDate) = 
        (vehicle, customer, kmRented, kmReturned, rentedAtDate, returnedAtDate);
    public int? CalcTotal()
    {
        var totalCostPerKm = (KmReturned - KmRented) * Vehicle.CostPerKm;
        TimeSpan? totalDays = (ReturnedAtDate - RentedAtDate);
        var totalCostPerDay = totalDays?.TotalDays * Vehicle.CostPerDay;
        var totalCost = totalCostPerKm + totalCostPerDay;
        return (int)totalCost;
    }
}
