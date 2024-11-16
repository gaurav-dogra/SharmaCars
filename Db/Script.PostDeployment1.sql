if not exists (select 1 from dbo.[User])
begin
	INSERT INTO dbo.[User] (FirstName, LastName)
	VALUES ('Atul', 'Sharma'),
	('Neha', 'Sharma');
end