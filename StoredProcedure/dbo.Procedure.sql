CREATE PROCEDURE GetCustomersFromFrance
	
AS
	SELECT * from Customers
Where Country = 'France'
Return
