USE Part8WCF;
GO

-- 1. Create tblEmployee
CREATE TABLE tblEmployee (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Gender NVARCHAR(50) NOT NULL,
    DateOfBirth DATETIME NOT NULL,
	EmployeeType INT,
	AnnualSalary INT,
	HourlyPay INT,
	HoursWorked INT
);
GO

-- 2. Add records to tblEmployee
--INSERT INTO tblEmployee (FirstName, LastName, Gender, DateOfBirth)
--VALUES 
--    ('Alice', 'Smith', 'Female', '2026-03-01'),
--    ('Bob', 'Jones', 'Male', '2026-03-02'),
--    ('Charlie', 'Brown', 'Male', '2026-03-03');
--GO

-- 3. Create spGetEmployee
CREATE PROCEDURE spGetEmployee
@Id INT
AS
BEGIN

	SELECT
		Id,
		FirstName,
		LastName,
		Gender,
		DateOfBirth,
		EmployeeType,
		AnnualSalary,
		HourlyPay,
		HoursWorked
	FROM 
		tblEmployee
	WHERE 
		Id = @Id

END
GO

-- 4. Create spSaveEmployee
CREATE PROCEDURE spSaveEmployee
@FirstName NVARCHAR(50),
@LastName NVARCHAR(50),
@Gender NVARCHAR(50),
@DateOfBirth DATETIME,
@EmployeeType INT,
@AnnualSalary INT = NULL,
@HourlyPay INT = NULL,
@HoursWorked INT = NULL
AS
BEGIN

	INSERT INTO tblEmployee
	(
		FirstName,
		LastName,
		Gender,
		DateOfBirth,
		EmployeeType,
		AnnualSalary,
		HourlyPay,
		HoursWorked
	)
	VALUES
	(
		@FirstName,
		@LastName,
		@Gender,
		@DateOfBirth,
		@EmployeeType,
		@AnnualSalary,
		@HourlyPay,
		@HoursWorked
	)

END