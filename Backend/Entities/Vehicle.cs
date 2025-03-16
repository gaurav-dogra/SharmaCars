﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities;

public class Vehicle
{
    public int Id { get; set; }
    public required string HeadlineSummary { get; set; }
    public int Status { get; set; }
    public string? Model { get; set; }
    public int? Mileage { get; set; }
    public int? RegistrationYear { get; set; }
    public int? Gearbox { get; set; }
    public int? FuelType { get; set; }
    public int? Price { get; set; }
    public int? PreviousOwners { get; set; }
    public int? ServiceHistory { get; set; }
    public bool? IsBrandNew { get; set; }
    public int? BodyType { get; set; }
    public int? Doors { get; set; }
    public int? Seats { get; set; }
    public int? Category { get; set; }
    public int? EmissionClass { get; set; }
    public int? EngineCapacity { get; set; }
    public int? BatteryRange { get; set; }
    public string? Description { get; set; }
    public int? Colour { get; set; }
    public int? DriveType { get; set; }
    public int? NumberOfKeys { get; set; }
    public bool? IsUlezCompliant { get; set; }

}
