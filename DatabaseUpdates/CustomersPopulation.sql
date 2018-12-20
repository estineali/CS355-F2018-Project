INSERT INTO Customers(CustomerID)
SELECT PersonID 
FROM Users
WHERE PersonID > 16 --Pls change this value to the PersonID of the last User in your database
