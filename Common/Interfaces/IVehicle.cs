using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;

public interface IVehicle
{
    string PlateNumber { get; init; }
    string Make {  get; init; }
    int Odometer { get; init; }
    double CostPerKm { get; init; }
    double CostPerDay { get; init; }
    VehicleTypes VehicleType { get; init; }
    VehicleStatuses VehicleStatus { get; init; }
}
