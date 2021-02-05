-- doto
CREATE TABLE Journal (
    Id SERIAL PRIMARY KEY,
    JournalEntry TEXT,
    TimeEntered TIMESTAMP
);

-- DATE OR TIMESTAMP HOW TO PUT IN>?

-- TO DO BELOW

INSERT INTO
    Books (Title, Author)
VALUES
    ('Like Authoring a Bike', 'Ben P. Lee');