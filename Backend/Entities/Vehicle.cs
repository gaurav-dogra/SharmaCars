﻿namespace Backend.Entities;

public class Vehicle
{
    public int Id { get; set; }
    public required string Summary { get; set; }
    public bool IsReadyForSale { get; set; }
    public string? Model { get; set; }
    public int? Mileage { get; set; }
    public string? Registration { get; set; }
    public int? RegistrationYear { get; set; }
    public int? GearboxType { get; set; }
    public int? FuelType { get; set; }
    public int? Price { get; set; }
    public int? NoOfPreviousOwners { get; set; }
    public int? ServiceHistory { get; set; }
    public bool? IsBrandNew { get; set; }
    public int? BodyType { get; set; }
    public int? NoOfDoors { get; set; }
    public int? NoOfSeats { get; set; }
    public int? Category { get; set; }
    public int? EmissionClass { get; set; }
    public int? EngineCapacity { get; set; }
    public int? BatteryRange { get; set; }
    public string? Description { get; set; }
    public int? Colour { get; set; }
    public int? DriveType { get; set; }
    public int? NoOfKeys { get; set; }
    public bool? IsUlezCompliant { get; set; }

}
