CREATE TABLE STUDETNS( 
 StudentID INT PRIMARY KEY, 
 FirstName VARCHAR(50), 
 Marks INT, 
 DOB DATE
); 

INSERT INTO STUDETNS (StudentID, FirstName, Marks, DOB)

VALUES

(2003, 'Amit', 92, '2003-05-10'), (22, 'Neha', 78, '2002-11-15'), (63, 'Rahul', 61, '2004-01-20'), (94, 'Sneha', 49, '2003-09-01'); 

SELECT * from STUDETNS