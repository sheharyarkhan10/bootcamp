--Task 1

CREATE DATABASE [5082_DB];
GO

USE [5082_DB];
GO

--Task 2 

CREATE TABLE Students (
ID INT PRIMARY KEY,
FirstName VARCHAR (50),
LastName VARCHAR (50),
Age INT,
COURSEID INT,
FOREIGN KEY (COURSEID) REFERENCES Courses (COURSEID)
);
GO

CREATE TABLE Courses (
COURSEID INT PRIMARY KEY,
CourseName VARCHAR (50),
);


--TASK 3
INSERT INTO Students (ID, FirstName, LastName, Age, COURSEID)
VALUES (1,  'Muhammad', 'Sheharyar' , 23, 1), 
       (2,  'Arslam', 'Munir' , 25, 1),
	   (3,  'Syed', 'Fawad' , 22, 2),
	   (4,  'Muhammad', 'Hamza' , 23, 3),
	   (5,  'Muhammad', 'Abdullah' , 23, 1),
	   (6,  'Hafiz', 'Zain' , 23, 2),
	   (7,  'Minahil', 'Idrees' , 21, 3),
	   (8,  'Talha', 'Rabbani' , 15, 1),
	   (9,  'Muhammad', 'Wasim' , 18, 2),
	   (10, 'Munam', 'Elahi' , 23, 3) 
	   
        
GO

INSERT INTO Courses (COURSEID, CourseName)
VALUES (1,  'Transmission'),
       (2,  'Digital Logics'),
       (3,  'Distribution');
GO


--Task 4

UPDATE Students
SET Age = 20
WHERE ID = 6;
GO

DELETE FROM Students
WHERE ID = 4;
GO

--TASK 5
SELECT * FROM Students
WHERE Age> 20;
GO

SELECT A.FirstName, A.Lastname, C.CourseName
FROM Students A
JOIN Courses C ON A.FirstName = C.CourseName
GO



--Task 6
SELECT COUNT (*) FROM Students;
GO

SELECT AVG(Age) FROM Students;
GO


--TASK 7

SELECT FirstName, LastName
FROM Students
WHERE COURSEID IS NULL;

SELECT TOP 1 * FROM Courses

SELECT * FROM Students
WHERE (Age)> 21;


SELECT COUNT(ID) AS  TOTALSTUDENTS , AVG(AGE) AS AVERAGEAGE
FROM Students
GROUP BY COURSEID

SELECT CourseName
FROM Courses
WHERE COURSEID IS NULL;

SELECT C.COURSEID
FROM Students A
JOIN Courses C ON A. = C.CourseName
GO

SELECT TOP 1 * FROM Students
WHERE Age > AVG(Age) ; 