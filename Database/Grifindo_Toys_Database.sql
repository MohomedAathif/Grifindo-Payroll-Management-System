CREATE DATABASE Grifindo_Toys

USE Grifindo_Toys

CREATE TABLE Employee (
	E_id INT PRIMARY KEY,
	E_f_name VARCHAR(50),
	E_l_name VARCHAR(50),
	Gender CHAR(1),
	Address CHAR(100),
	DOB DATE,
	Monthly_salary MONEY,
	OT_rate MONEY,
	Allowance MONEY,
	Tax INT
)


CREATE TABLE Settings(
	StartDate DATE,
	EndDate DATE,
	No_of_leaves INT,
	RangeCycle INT
)


CREATE TABLE Salary (
	Salary_id INT PRIMARY KEY,
	E_id INT FOREIGN KEY REFERENCES.Employee,
	StartDate DATE,
	EndDate DATE,
	Basepay MONEY,
	Tax INT,
	GrossPay MONEY
)

CREATE TABLE Attendance(
	Att_id INT PRIMARY KEY,
	E_id INT FOREIGN KEY REFERENCES.Employee
	No_hours_worked INT,
	No_ot_hours INT,
)

CREATE TABLE Attendance (
    Att_id INT PRIMARY KEY,
    E_id INT,
    No_hours_worked INT,
    No_ot_hours INT,
    FOREIGN KEY (E_id) REFERENCES Employee(E_id)
)


SELECT * FROM Login

CREATE TABLE PayRoll(
	PR_id INT PRIMARY KEY,
	E_id INT FOREIGN KEY REFERENCES.Employee,
	E_f_name VARCHAR(50),
	E_l_name VARCHAR(50),
	Monthly_salary FLOAT,
	Allowance FLOAT,
	othours FLOAT,
	NoPay FLOAT,
	BasePay FLOAT,
	GrossPay FLOAT,
	PaymentDate DATE

)

CREATE TABLE Login(
	username VARCHAR(50),
	password VARCHAR(50)
)

INSERT INTO Login (username, password)
VALUES ('Admin', 'Admin@123')

SELECT * FROM Login

SELECT * FROM PayRoll

SELECT * FROM Salary

SELECT PR_id AS 'Payroll ID', E_id AS 'Employee ID', E_f_name AS 'First Name', E_l_name AS 'Last Name', Monthly_salary AS 'Monthly Salary', Allowance, othours AS 'OT Hours', NoPay AS 'NO PAY',BasePay AS 'BASE PAY',GrossPay AS 'Gross Salary', PaymentDate as 'Salary Date'  FROM PayRoll;
