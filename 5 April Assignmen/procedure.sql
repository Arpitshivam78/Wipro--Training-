-- table
CREATE TABLE PRODUCTS( 
     ProductID INT PRIMARY KEY, 
	 ProductName VARCHAR(100), 
	 PRICE DECIMAL(10,2) 
); 


-- execution
CREATE PROCEDURE GETALLPRODUCTS 
AS 
BEGIN 
    SELECT * FROM PRODUCTS; 
END;   

-- execution  
EXEC GETALLPRODUCTS;  

-- HIGHERend  
CREATE PROCEDURE HigherEndProducts 
AS 
BEGIN 
    SELECT * FROM PRODUCTS 
	WHERE PRICE > 60000; 
END;  


-- 
CREATE PROCEDURE GetOrdersByProducts 
    @ProductID INT 
	
AS 
BEGIN 
    SELECT 
	    O.OrderID, 
		O.QUANTITY, 
		O.OrderDate, 
		P.ProductName, 
		P.PRICE 
	FROM ORDERS O 
	INNER JOIN PRODUCTS p ON O.ProductID = P.ProductID 
	WHERE O.ProductID = @ProductID; 
END; 	