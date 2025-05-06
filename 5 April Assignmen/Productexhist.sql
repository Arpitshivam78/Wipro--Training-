CREATE PROCEDURE CheckProductExhists 
      (@ProductID INT
) 

AS 
BEGIN 
      IF EXISTS (SELECT 1 FROM PRODUCTS WHERE ProductID = @ProductID) 
	  BEGIN 
	       PRINT 'PRODUCT EXISTS' 
      END 
	  ELSE 
	  BEGIN 
	       PRINT 'PRODUCT NOT FOUND' 
      END 
END 
--
EXEC CheckProductExhists @ProductID = 24 