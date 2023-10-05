1. Customer:
a. CustomerId (primary key, int, not null)
b. Name (varchar(50))
2. Product:
a. ProductId (primary key, int, not null)
b. Name (varchar(100))
c. Price (decimal(12, 2))
3. Order
a. OrderId (primary key, int, not null)
b. CustomerId (foreign key, int, not null)
c. CreatedAt (datetime, not null)
4. OrderProduct
a. OrderProductId (primary key, int, not null)
b. OrderId (foreign key, int, not null)
c. ProductId (foreign key, int, not null)

Imagine the following schema in a database.
Write the SQL/ LINQ queries to return data for the following requirements.
Queries do not need to be executed. You can use a simple text editor.
● all the customers whose name begins with "Joe"
● all the product names ordered by customer "Joe" after '11/1/2016'
● the total amount spend by customer "Joe"
● all the customer names and count of their orders for orders containing more than one
product

1. 
SELECT * FROM Customer WHERE Name LIKE 'Joe%';

2.
SELECT DISTINCT P.Name
FROM Product P
JOIN OrderProduct OP ON P.ProductId = OP.ProductId
JOIN [Order] O ON OP.OrderId = O.OrderId
JOIN Customer c ON O.CustomerId = C.CustomerId
WHERE C.Name = 'Joe'
AND O.CreatedAt > '2016-11-01'

3.
SELECT C.Name AS CustomerName, SUM(P.Price) AS TotalAmount
FROM Customer C
JOIN [Order] O ON C.CustomerId = O.CustomerId
JOIN OrderProduct OP ON OP.OrderId = O.OrderId
JOIN Product P ON OP.ProductId = P.ProductId
WHERE C.Name = 'Joe'
GROUP BY C.Name; 

4.
SELECT C.Name AS CustomerName, COUNT(O.OrderId) AS OrderCount
FROM Customer C
JOIN [Order] O ON C.CustomerId = O.CustomerId
JOIN (
	SELECT O.OrderId
	FROM [Ordeer] O
	JOIN OrderProduct OP ON O.OrderId = OP.OrderId
	GROUP BY O.OrderId
	HAVING COUNT(OP.ProductId) > 1
) AS MultiProductOrders ON O.OrderId = MultiProductOrders.OrderId
GROUP BY C.Name;