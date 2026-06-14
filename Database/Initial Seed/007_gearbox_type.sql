INSERT INTO gearbox_type
VALUES ('Automatic'),
       ('Manual')
ON CONFLICT (name) DO NOTHING ;
