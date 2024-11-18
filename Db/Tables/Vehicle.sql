﻿CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [HeadlineSummary] NVARCHAR(100) NOT NULL,
    [Status] INT NOT NULL DEFAULT 1,
    [Model] NVARCHAR(100) NULL, 
    [Mileage] INT NULL, 
    [RegisterationYear] INT NULL, 
    [Gearbox] INT NULL, 
    [FuelType] INT NULL, 
    [Price] INT NULL, 
    [PreviousOwners] INT NULL, 
    [ServiceHistory] INT NULL, 
    [BrandNew] BIT NULL, 
    [BodyType] INT NULL, 
    [Doors] INT NULL, 
    [Seats] INT NULL, 
    [Category] INT NULL, 
    [EmissionClass] INT NULL, 
    [EngineCapacity] INT NULL, 
    [BatteryRange] INT NULL, 
    [Description] NVARCHAR(1000) NULL, 
    [Colour] INT NULL, 
    [DriveType] INT NULL, 
    FOREIGN KEY (RegisterationYear) REFERENCES RegisterationYear(Id),
    FOREIGN KEY (Gearbox) REFERENCES GearboxType(Id),
    FOREIGN KEY (FuelType) REFERENCES FuelType(Id),
    FOREIGN KEY (ServiceHistory) REFERENCES ServiceHistory(Id),
    FOREIGN KEY (BodyType) REFERENCES BodyType(Id),
    FOREIGN KEY (Category) REFERENCES CategoryType(Id),
    FOREIGN KEY (EmissionClass) REFERENCES EmissionClass(Id),
    FOREIGN KEY (EngineCapacity) REFERENCES EngineCapacity(Id),
    FOREIGN KEY (Colour) REFERENCES Colour(Id),
    FOREIGN KEY (DriveType) REFERENCES DriveType(Id)
	
)
