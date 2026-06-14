INSERT INTO fuel_type
VALUES ('Petrol'),
       ('Diesel'),
       ('Electric'),
       ('Hybrid'),
       ('Other')
ON CONFLICT (name) DO NOTHING;