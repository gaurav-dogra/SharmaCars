CREATE PROCEDURE [dbo].[spUserHash_Update]
@Id int,
@Hash nvarchar(100)
AS
begin
	UPDATE dbo.UserHash 
	SET [Hash] = @Hash
	WHERE Id = @Id;
end