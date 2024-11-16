CREATE TABLE [dbo].[VehicleImages]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VehicleId] INT NOT NULL, 
    [ImagePath] NVARCHAR(255) NOT NULL, 
    [IsMainImage] BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_VehicleImages_Vehicle FOREIGN KEY (VehicleId) REFERENCES Vehicle(Id),
    CONSTRAINT CK_OneMainImage CHECK (
        IsMainImage = 0 OR
        (SELECT COUNT(*) FROM VehicleImages WHERE VehicleId = VehicleImages.VehicleId AND IsMainImage = 1) <= 1
    )


);
