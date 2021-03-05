-- doto
CREATE TABLE Journal (
    Id SERIAL PRIMARY KEY,
    JournalEntry TEXT,
    DateOfEntry TIMESTAMP NOT NULL DEFAULT NOW(),
    
);

-- ,
  --  Mood VARCHAR(20)

-- just an idea
CREATE TABLE Keywords (CREATE TABLE Keywords (
    Keyword PRIMARY KEY TEXT,
    JournalEntry SECONDARY KEY[]
);




    Keyword PRIMARY KEY TEXT,
    JournalEntry Seco
);

-- DATE OR TIMESTAMP HOW TO PUT IN>?

-- TO DO BELOW
-- could add keywords later if we want...

INSERT INTO
    Journal (JournalEntry,DateOfEntry)
VALUES
    ('Hackathon today....',(SELECT NOW()));


    INSERT INTO
    Journal (JournalEntry)
VALUES
    ('Hackathon today....');