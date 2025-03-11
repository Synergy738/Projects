CREATE TABLE 'CUSTOMERS' (
    "CUSTOMER_ID" INT(10) NOT NULL UNIQUE PRIMARY KEY,
    "LAST_NAME" VARCHAR2(25) NOT NULL,
    "FIRST_NAME" VARCHAR2(25) NOT NULL,
    "HOME_PHONE" VARCHAR2(12) NOT NULL,
    "ADDRESS" VARCHAR2(100) NOT NULL,
    "CITY" VARCHAR2(30) NOT NULL,
    "STATE" VARCHAR2(2) NOT NULL,
    "EMAIL" VARCHAR2(25),
    "CELL_PHONE" VARCHAR2(12)
);

INSERT INTO 'CUSTOMERS'(CUSTOMER_ID, LAST_NAME, FIRST_NAME, HOME_PHONE, ADDRESS, CITY, STATE, EMAIL, CELL_PHONE)
VALUES(1, 'Dennis', 'Blu', '123-456-7890', '36 Kunene Rd', 'Cape Town', 'WP', 'bludennis17@gmail.com', '064-766-9310'),
(2, 'Smith', 'John', '123-456-7891', '37 Kunene Rd', 'Cape Town', 'WP', 'johnsmith17@gmail.com', '064-766-9311'),
(3, 'Johnson', 'Jane', '123-456-7892', '38 Kunene Rd', 'Cape Town', 'WP', 'janejohnson17@gmail.com', '064-766-9312'),
(4, 'Williams', 'Robert', '123-456-7893', '39 Kunene Rd', 'Cape Town', 'WP', 'robertwilliams17@gmail.com', '064-766-9313'),
(5, 'Brown', 'Michael', '123-456-7894', '40 Kunene Rd', 'Cape Town', 'WP', 'michaelbrown17@gmail.com', '064-766-9314'),
(6, 'Taylor', 'Sarah', '123-456-7895', '41 Kunene Rd', 'Cape Town', 'WP', 'sarahtaylor17@gmail.com', '064-766-9315');

CREATE TABLE 'MOVIES' (
    "TITLE_ID" NUMBER(10) NOT NULL UNIQUE PRIMARY KEY,
    "TITLE" VARCHAR2(60) NOT NULL,
    "DESCRIPTION" VARCHAR2(400) NOT NULL,
    "RATING" VARCHAR2(4) CHECK(RATING IN ('G', 'PG', 'PG13', 'R')),
    "CATEGORY" VARCHAR(20) CHECK(CATEGORY IN ('DRAMA', 'COMEDY', 'ACTION', 'CHILD', 'SCIFI', 'DOCUMENTARY')),
    "RELEASE_DATE" DATE NOT NULL
);

INSERT INTO 'MOVIES' ('TITLE_ID', 'TITLE', 'DESCRIPTION', 'RATING', 'CATEGORY', 'RELEASE_DATE')
VALUES (1, 'The Great Adventure', 'A group of friends embark on a dangerous journey in an effort to imprison their town''s dangerous new ruler.', 'PG13', 'ACTION', TO_DATE('2024-07-01','YYYY-MM-DD')),
(2, 'Life in the Woods', 'A dramatic story of a man who lived alone in the woods for over 30 years.', 'PG', 'DRAMA', TO_DATE('2023-11-15','YYYY-MM-DD')),
(3, 'The Last Stand', 'An action-packed saga of a company of heroes against an unimaginable threat.', 'R', 'ACTION', TO_DATE('2024-02-20','YYYY-MM-DD')),
(4, 'Funny Business', 'A comedy about a group of friends competing in a national poker tournament.', 'PG', 'COMEDY', TO_DATE('2024-05-10','YYYY-MM-DD')),
(5, 'Space Adventure', 'A sci-fi epic set in a distant galaxy in the far future.', 'PG13', 'SCIFI', TO_DATE('2024-04-01','YYYY-MM-DD')),
(6, 'The Lost World', 'A documentary about an expedition to a remote jungle.', 'G', 'DOCUMENTARY', TO_DATE('2023-12-12','YYYY-MM-DD'));

CREATE TABLE 'MEDIA' (
    'MEDIA_ID' NUMBER(10) NOT NULL UNIQUE PRIMARY KEY,
    'FORMAT' VARCHAR2(3) NOT NULL,
    'TITLE_ID' INT(10) NOT NULL,
    FOREIGN KEY(TITLE_ID) REFERENCES MOVIES('TITLE_ID')
);

INSERT INTO MEDIA (FORMAT, TITLE_ID)
SELECT 'DVD', TITLE_ID FROM MOVIES
UNION ALL
SELECT 'Blu-ray', TITLE_ID FROM MOVIES;

CREATE TABLE 'RENTAL HISTORY' (
    'MEDIA_ID' INT(10) NOT NULL,
    'RENTAL_DATE' DATE NOT NULL DEFAULT CURRENT_DATE,
    'CUSTOMER_ID' INT(10) NOT NULL,
    'RETURN_DATE' DATE,
    PRIMARY KEY (MEDIA_ID, RENTAL_DATE),
    FOREIGN KEY (MEDIA_ID) REFERENCES MEDIA(MEDIA_ID),
    FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMERS(CUSTOMER_ID)
);

INSERT INTO 'RENTAL HISTORY' (MEDIA_ID, RENTAL_DATE, CUSTOMER_ID, RETURN_DATE)
VALUES()
