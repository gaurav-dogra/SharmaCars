CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	SELECT Id, FirstName, LastName, UserGroup, [Status] 
	FROM dbo.[User];
end