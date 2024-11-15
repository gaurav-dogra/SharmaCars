CREATE PROCEDURE [dbo].[spUserHash_Insert]
@Id integer,
@Hash nvarchar(100)
AS
	begin
	INSERT INTO dbo.UserHash (Id, [Hash]) 
	VALUES (@Id, @Hash);
end