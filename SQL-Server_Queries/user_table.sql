use MyDB;


CREATE TABLE usr_tbl (
    id INT PRIMARY KEY IDENTITY(1,1),   -- Auto-increment in SQL Server
    name VARCHAR(50) NOT NULL,
    gender VARCHAR(10) CHECK (gender IN ('Male', 'Female', 'Other')),
    age INT CHECK (age >= 0),
    email VARCHAR(100) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL
);

INSERT INTO usr_tbl (name, gender, age, email, password)
VALUES ('Ashish Senapati', 'Male', 23, 'ashish@example.com', 'Pass@123');

INSERT INTO usr_tbl (name, gender, age, email, password)
VALUES ('Sneha Patnaik', 'Female', 25, 'sneha@example.com', 'MySecurePwd!');

INSERT INTO usr_tbl (name, gender, age, email, password)
VALUES ('Rohan Kumar', 'Male', 28, 'rohan.kumar@example.com', 'Rohan#2025');

