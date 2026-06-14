INSERT INTO status (name)
VALUES ('Draft'),
       ('Active'),
       ('Sold'),
       ('Hold')
ON CONFLICT (name) DO NOTHING;

