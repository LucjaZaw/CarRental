using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Motorcycle : IVehicle
{
    public string PlateNumber { get; init; }
    public string Make { get; init; }
    public int Odometer { get; init; }
    public int CostPerKm { get; init; }
    public int CostPerDay { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public VehicleStatuses VehicleStatus { get; init; }

    public Motorcycle(string plateNumber, string make, int odometer, 
        int costPerKm,int costPerDay, VehicleTypes vehicleType, VehicleStatuses vehicleStatus) => 
        (PlateNumber, Make, Odometer, CostPerKm, CostPerDay, VehicleType, VehicleStatus) = 
        (plateNumber, make, odometer, costPerKm, costPerDay, vehicleType, vehicleStatus);


    
}
