-- Employee Table
CREATE TABLE EMPLOYEE( 
EmployeeID INT PRIMARY KEY, 
FIRSTNAME VARCHAR(50), 
LASTNAME VARCHAR(50), 
Department VARCHAR(50), 
SALARY DECIMAL(10, 2), 
HireDate DATE 

);   

-- delete 
DELETE FROM EMPLOYEE WHERE EMPLOYEEID = 4001 

SELECT * FROM EMPLOYEE 