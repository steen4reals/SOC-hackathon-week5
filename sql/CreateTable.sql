-- doto
CREATE TABLE Journal (
    Id SERIAL PRIMARY KEY,
    JournalEntry TEXT,
    TimeEntered TIMESTAMP
);

-- DATE OR TIMESTAMP HOW TO PUT IN>?

-- TO DO BELOW
-- could add keywords later if we want...

INSERT INTO
    Journal (JournalEntry)
VALUES
    ('Like Authoring a Bike', 'Ben P. Lee');