--This is SQL
--This is for comments


--When you don't highlight a specific command before run/executing, everything in the current (open) SQL file runs.
--you can select a specific command, and only that command will run. 


SELECT * FROM Album;
--When you run a query, the results take the form of a table.

SELECT 'Hello World';
--Single quotes denote strings in SQL

SELECT 2 + 2

SELECT SYSUTCDATETIME()

--Usually, nothing in SQL is case sensitive
--Semi colons not required to end a line. They can be useful to denote the end of an operation/thought.
select 2+2; 

--When you make a query to a db, any result will take the form of a table. 
--SELECT (Columns) FROM (Table)
SELECT FirstName FROM CUSTOMER;



--When selecting multiple columns from a table, seperate them with a comma. 
SELECT FirstName, LastName FROM Customer;

SELECT FirstName + ' ' + LastName FROM Customer;

SELECT FirstName + ' ' + LastName AS Fullname FROM CUSTOMER;
SELECT FirstName + ' ' + LastName AS 'Full name' FROM CUSTOMER;
SELECT FirstName + ' ' + LastName AS [Fullname] FROM CUSTOMER;

SELECT * FROM Customer;


--Filtering with WHERE

SELECT * -- Get this/these columns 
FROM CUSTOMER -- From this table
WHERE LEN(FirstName) > 4; -- for entries that meet this condition.

SELECT *
FROM Customer
WHERE Country = 'Chile' AND City = 'Santiago'; -- You can use AND to chain multiple conditions together.

--Aggregate functions

SELECT COUNT(*)
FROM CUSTOMER;

SELECT SUM(Total)
FROM INVOICE;

SELECT MIN(Total)
FROM INVOICE;

--other agg functuions like min, max, average


SELECT CustomerId, SUM(Total)
FROM Invoice
GROUP BY CustomerId; -- Group by gives us a way to group the result of an agg function by entries 



--Here is an example of a complex query with multiple filters
SELECT CustomerId, SUM(Total) AS Sum_Total --Selects the customer ID AND the total sum of all invoices that belong to that customer, aliased as Sum_Total.
FROM INVOICE --Selects the above data, from the invoice table.
WHERE BillingCountry != 'USA' --Filters the data and only keeps data where the BillingCountry ISNT the USA.
GROUP BY CustomerId --Group the data being returned by the CustomerID
HAVING SUM(Total) > 40 --Another filter, this time only keep data where the sum of all a customers invoices total more than 40.
ORDER BY Sum_Total DESC, CustomerId; --Orders the returning data by the Sum_Total in descending order, and display the CustomerID next to that total. 

-- Logical order of operations is:
-- FROM
-- WHERE
-- GROUP BY
-- HAVING
-- SELECT
-- ORDER BY


--Joins
--Accessing multiple tables to return the desired data

--GET every album by artist 
SELECT Album.Title AS 'Album Title', Artist.Name AS 'Artist Name'
FROM Album LEFT JOIN Artist ON Album.ArtistId = Artist.ArtistId;

--Many types of joins exist.
--Cross Join
--Inner Joins
--Left/Right Joins 
--Outer Joins
--Etc

--It can be useful to visualize joins as venn diagrams. 
--https://www.w3schools.com/sql/sql_join.asp

