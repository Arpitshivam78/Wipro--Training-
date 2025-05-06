CREATE PROCEDURE ShowRevenue@2
    @ProductID INT 
	
AS 
BEGIN 
    SELECT 
	    P.ProductName, 
		SUM(O.Quantity * P.PRICE) AS TotalRevenue 
    FROM ORDERS O 
    INNER JOIN PRODUCTS P ON O.ProductID = P.ProductID 
    WHERE O.ProductID = @ProductID 
    GROUP BY P.ProductName; 
END; 

-- 
EXEC ShowRevenue@2  @ProductID = 1;  