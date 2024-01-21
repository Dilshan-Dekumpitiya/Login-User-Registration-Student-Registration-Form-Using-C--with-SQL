-- users table

CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	email VARCHAR(20) NULL,
	username VARCHAR(20) NULL,
	password VARCHAR(20) NULL,
	date_created DATE NULL,
)

-- student table

CREATE TABLE student
(
    studentID VARCHAR(50) PRIMARY KEY,
    studentFirstName varchar(50) NOT NULL,
    studentLastName varchar(50) NOT NULL,
    studentDOB dateTime NOT NULL,
    studentGender varchar(50) NOT NULL,
    studentAddress varchar(50) NOT NULL,
    studentEmail varchar(50) NOT NULL,
    studentMobilePhone Integer NOT NULL,
    studentHomePhone Integer NOT NULL,
    parentName varchar(50) NOT NULL,
    parentNIC varchar(50) NOT NULL,
    parentContactNo Integer NOT NULL,
    
);
