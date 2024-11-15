CREATE PROCEDURE [dbo].[spUser_Get]
@Id int
AS
	begin
	SELECT Id, FirstName, LastName, UserGroup, [Status] 
	FROM dbo.[User]
	WHERE Id = @Id;
end