if not exists (select 1 from dbo.[User])
begin
	INSERT INTO dbo.[User] (FirstName, LastName)
	VALUES ('Atul', 'Sharma'),
	('Neha', 'Sharma');
end;

INSERT INTO [BodyType] 
VALUES	('Convertible'), 
		('Coupe'), 
		('Estate'),
		('Hatchback'),
		('MPV'),
		('Pickup'),
		('Saloon'),
		('SUV'),
		('Camper'),
		('Limousine'),
		('Minibus'),
		('Van');
		-- ('Other');

INSERT INTO [CategoryType] 
VALUES	('A'), 
		('B'), 
		('S'),
		('N');

INSERT INTO [Colour] 
VALUES	('Black'), 
		('Blue'), 
		('Grey'),
		('White'),
		('Silver'),
		('Red'),
		('Green'),
		('Beige'),
		('Bronze'),
		('Brown'),
		('Gold'),
		('Multicolor'),
		('Orange'),
		('Pink'),
		('Purple'),
		('Yellow');
		-- ('Other'); ??

INSERT INTO [DriveType]
VALUES ('Four Wheel Drive'),
		('Front Wheel Drive'),
		('Rear Wheel Drive');

INSERT INTO [EmissionClass]
VALUES ('Euro 1'),
	   ('Euro 2'),
	   ('Euro 3'),
	   ('Euro 4'),
	   ('Euro 5'),
	   ('Euro 6');

INSERT INTO [EngineCapacity]
VALUES ('<1.0L'),
		('1.0L'),
		('1.2L'),
		('1.4L'),
		('1.6L'),
		('1.8L'),
		('1.9L'),
		('2.0L'),
		('2.2L'),
		('2.4L'),
		('2.6L'),
		('3.0L'),
		('3.5L'),
		('4.0L'),
		('4.5L'),
		('5.0L'),
		('5.5L'),
		('6.0L'),
		('6.5L'),
		('7.0L');


INSERT INTO [FuelType]
VALUES ('Petrol'),
		('Diesel'),
		('Electric'),
		('Hybrid'),
		('Bi Fuel'),
		('Hydrogen'),
		('Natural Gas');

INSERT INTO [GearboxType]
VALUES ('Automatic'),
	   ('Manual');

INSERT INTO [RegisterationYear]
VALUES ('1980'),
       ('1981'),
       ('1982'),
       ('1983'),
       ('1984'),
       ('1985'),
       ('1986'),
       ('1987'),
       ('1988'),
       ('1989'),
       ('1990'),
       ('1991'),
       ('1992'),
       ('1993'),
       ('1994'),
       ('1995'),
       ('1996'),
       ('1997'),
       ('1998'),
       ('1999'),
       ('2000'),
       ('2001'),
       ('2001 (51 reg)'),
       ('2002 (02 reg)'),
       ('2002 (52 reg)'),
       ('2003 (03 reg)'),
       ('2003 (53 reg)'),
       ('2004 (04 reg)'),
       ('2004 (54 reg)'),
       ('2005 (05 reg)'),
       ('2005 (55 reg)'),
       ('2006 (06 reg)'),
       ('2006 (56 reg)'),
       ('2007 (07 reg)'),
       ('2007 (57 reg)'),
       ('2008 (08 reg)'),
       ('2008 (58 reg)'),
       ('2009 (09 reg)'),
       ('2009 (59 reg)'),
       ('2010 (10 reg)'),
       ('2010 (60 reg)'),
       ('2011 (11 reg)'),
       ('2011 (61 reg)'),
       ('2012 (12 reg)'),
       ('2012 (62 reg)'),
       ('2013 (13 reg)'),
       ('2013 (63 reg)'),
       ('2014 (14 reg)'),
       ('2014 (64 reg)'),
       ('2015 (15 reg)'),
       ('2015 (65 reg)'),
       ('2016 (16 reg)'),
       ('2016 (66 reg)'),
       ('2017 (17 reg)'),
       ('2017 (67 reg)'),
       ('2018 (18 reg)'),
       ('2018 (68 reg)'),
       ('2019 (19 reg)'),
       ('2019 (69 reg)'),
       ('2020 (20 reg)'),
       ('2020 (70 reg)'),
       ('2021 (21 reg)'),
       ('2021 (71 reg)'),
       ('2022 (22 reg)'),
       ('2022 (72 reg)'),
       ('2023 (23 reg)'),
       ('2023 (73 reg)'),
       ('2024 (24 reg)'),
       ('2024 (74 reg)'),
       ('2025 (25 reg)'),
       ('2025 (75 reg)'),
       ('2026 (26 reg)'),
       ('2026 (76 reg)'),
       ('2027 (27 reg)'),
       ('2027 (77 reg)'),
       ('2028 (28 reg)'),
       ('2028 (78 reg)'),
       ('2029 (29 reg)'),
       ('2029 (79 reg)'),
       ('2030 (30 reg)'),
       ('2030 (80 reg)');


	   




		