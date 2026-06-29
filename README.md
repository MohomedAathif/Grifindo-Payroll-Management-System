# Grifindo Payroll System

The Grifindo Payroll System is a Windows desktop based payroll management application developed for Grifindo Toys, a small scale toy manufacturing company located in the United Kingdom. The company employs approximately 50 employees and required a simple, reliable system to manage employee details, calculate monthly salaries, and generate payroll reports.
This system was developed as a freelance software solution using C# Windows Forms and SQL Server, focusing on accuracy, simplicity, and ease of use for administrative staff.

# Key Features

- **Admin Authentication** - Secure login system that restricts access to authorized administrative users only.
- **Employee Management** - Manage employee salary related information including monthly salary, overtime rates, allowances, and tax details used for payroll processing.
- **Salary Cycle Configuration** - Configure salary cycle start date, end date, and cycle duration to ensure salaries are calculated only within approved date ranges.
- **Attendance and Leave Handling** - Calculate employee attendance based on absent days within the salary cycle and apply no pay deductions accordingly.
- **Automated Salary Calculation** - Automatically compute no pay, base pay, and gross salary using predefined payroll formulas.
- **Overtime and Allowance Processing** - Accurately calculate overtime payments and allowances as part of the base salary.
- **Tax Computation** - Automatically determine and deduct government tax based on salary ranges.
- **Payroll Processing and Storage** - Confirm and store monthly payroll records for each employee in the database.
- **Payroll Reporting** - Generate payroll reports displaying employee salary details, deductions, and payment history.
- **Database Integration** - Uses Microsoft SQL Server for secure and reliable data storage and retrieval.

# Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Windows Forms
- **Database:** Microsoft SQL Server
- **IDE:** Visual Studio

# How to Run the Project

- Open the solution file in Visual Studio
- Restore database using SQL Server and update the connection string if required
- Build the solution
- Run the application
- Login using admin credentials
- Configure salary cycle settings before calculating salaries
