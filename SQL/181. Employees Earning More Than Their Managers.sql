-- The way to compare a table to itself is to perform a join on itself.
-- However, this means that both tables have the exact same name (in this case, 'Employee'),
-- which prevents you from differentiating between the two. To solve this, SQL provides the AS
-- operator to create aliases for tables/columns.

-- Note: another weird thing you might notice here is the ability to reference an alias before
-- it's actually declared.
SELECT a.name AS Employee
FROM Employee AS a JOIN Employee AS b
ON a.managerId = b.Id AND a.Salary > b.Salary
;
