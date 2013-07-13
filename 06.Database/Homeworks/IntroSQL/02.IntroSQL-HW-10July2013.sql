--04. Write a SQL query to find all information about all departments.

SELECT * FROM Departments;

--05. Write a SQL query to find all department names.

SELECT Name FROM Departments;

--06. Write a SQL query to find the salary of each employee.

SELECT Firstname, Lastname, Salary FROM Employees;

--07.Write a SQL to find the full name of each employee.

SELECT Firstname + ' ' + Lastname FullName 
FROM Employees

--08.Write a SQL query to find the email addresses 
--of each employee (by his first and last name). 
--Consider that the mail domain is telerik.com. 
--Emails should look like “John.Doe@telerik.com". 
--The produced column should be named "Full Email Addresses".

SELECT Firstname + '.' + Lastname + '@telerik.com' [Full Email Addresses]
FROM Employees

--09.Write a SQL query to find all different employee salaries.

SELECT Salary AS [Unique Salaries]  
FROM Employees
INTERSECT 
SELECT Salary 
FROM Employees
ORDER BY [Unique Salaries]

--10. Write a SQL query to find all 
--information about the employees whose job 
--title is “Sales Representative“.

SELECT * FROM Employees e
WHERE e.JobTitle = 'Sales Representative';

--11.Write a SQL query to find the names 
--of all employees whose first name starts with "SA".

SELECT Firstname, Lastname 
FROM Employees e
WHERE e.FirstName like 'SA%';

--12. Write a SQL query to find the names of 
--all employees whose last name contains "ei".

SELECT Firstname + ' ' + Lastname [Lastname contains "ei"]
FROM Employees e 
WHERE e.LastName like '%ei%';

--13. Write a SQL query to find the salary 
--of all employees whose salary is 
--in the range [20000…30000].

SELECT Firstname, Lastname, Salary
FROM Employees e
WHERE e.Salary BETWEEN 20000 AND 30000;

--14. Write a SQL query to find the names 
--of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT Firstname, Lastname, Salary
FROM Employees e
WHERE e.Salary In (25000, 14000, 12500, 23600);

--15. Write a SQL query to find all employees that 
--do not have manager.

SELECT Firstname, Lastname, ManagerID
FROM Employees e 
WHERE e.ManagerID is NULL

--16. Write a SQL query to find all employees that 
--have salary more than 50000. Order them in 
--decreasing order by salary.

SELECT Firstname, Lastname, Salary
FROM Employees e
WHERE e.Salary > 50000
ORDER BY e.Salary DESC

--17. Write a SQL query to find the top 5 
--best paid employees.

SELECT TOP 5 Salary, Firstname, Lastname 
FROM Employees e
ORDER BY e.Salary DESC

--18.Write a SQL query to find all 
--employees along with their address. 
--Use inner join with ON clause.

SELECT e.FirstName, e.LastName, a.AddressText
AS [Employee Adresses]
FROM Employees e INNER JOIN Addresses a
ON e.AddressID = a.AddressID

--19.Write a SQL query to find all employees 
--and their address. Use equijoins (conditions in 
--the WHERE clause).

SELECT e.FirstName, e.LastName, 
a.AddressText AS [Employee Adresses]
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

--20.Write a SQL query to find all employees along with their manager.

SELECT e.FirstName, e.LastName, m.LastName AS [Managers Name]
FROM Employees e INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID

--21.Write a SQL query to find all employees, 
--along with their manager and their address. 
--Join the 3 tables: Employees e, Employees m and 
--Addresses a.

SELECT e.LastName + '''s manager is ' + m.LastName 
+ ' ' + a.AddressText AS [Employee and his Manager]
FROM ((Employees e 
	INNER JOIN Employees m
		ON e.ManagerID = m.EmployeeID)
	INNER JOIN Addresses a
		ON a.AddressID = e.AddressID)

--22.Write a SQL query to find all departments 
--and all region names, country names and 
--city names as a single list. Use UNION.

SELECT d.Name
FROM Departments d
UNION
SELECT t.Name
FROM Towns t

--23. Write a SQL query to find all the employees 
--and the manager for each of them along with the 
--employees that do not have manager. User right outer join. 
--Rewrite the query to use left outer join.
 
SELECT e.LastName AS [Employee], m.LastName AS [Manager]
FROM Employees e RIGHT OUTER JOIN Employees m 
ON e.EmployeeID = m.ManagerID

SELECT e.LastName AS [Employee], m.LastName AS [Manager]
FROM Employees e LEFT OUTER JOIN Employees m 
ON e.ManagerID = m.EmployeeID

--24. Write a SQL query to find the names of all employees 
--from the departments "Sales" and "Finance" whose 
--hire year is between 1995 and 2000.

SELECT *
FROM Employees e JOIN Departments d
ON e.DepartmentID = d.DepartmentID
AND (d.Name IN ('Sales', 'Finance'))
AND (YEAR(e.HireDate) BETWEEN 1995 AND 2000)