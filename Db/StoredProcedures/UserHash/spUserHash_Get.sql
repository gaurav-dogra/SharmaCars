CREATE PROCEDURE [dbo].[spUserHash_Get]
@Id int
AS
	begin
	SELECT Id, [Hash] 
	FROM dbo.UserHash
	WHERE Id = @Id;
end