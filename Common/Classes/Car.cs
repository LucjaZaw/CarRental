﻿using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes
{
    public class Car : IVehicle
    {
        public string PlateNumber { get; init; }
        public string Make { get; init; }
        public int Odometer { get; init; }
        public double CostPerKm { get; init; }
        public double CostPerDay { get; init; }
        public VehicleTypes VehicleType { get; init; }
        public VehicleStatuses VehicleStatus { get; init; }

        public Car(string plateNumber, string make, int odometer,
            double costPerKm, double costPerDay, VehicleTypes vehicleType, VehicleStatuses vehicleStatus) =>
            (PlateNumber, Make, Odometer, CostPerKm, CostPerDay, VehicleType, VehicleStatus) =
            (plateNumber, make, odometer, costPerKm, costPerDay, vehicleType, vehicleStatus);
    }
}