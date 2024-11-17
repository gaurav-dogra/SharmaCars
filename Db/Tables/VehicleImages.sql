CREATE TABLE VehicleImages (
	Id INT IDENTITY PRIMARY KEY,
	VehicleId INT NOT NULL,
	ImagePath NVARCHAR(255) NOT NULL,
	IsMainImage BIT NOT NULL DEFAULT 0,
	CONSTRAINT FK_VehicleImages_Vehicle FOREIGN KEY (VehicleId) REFERENCES Vehicle(Id)
);

CREATE UNIQUE INDEX UX_OneMainImagePerVehicle 
ON VehicleImages (VehicleId, IsMainImage) 
WHERE IsMainImage = 1;
