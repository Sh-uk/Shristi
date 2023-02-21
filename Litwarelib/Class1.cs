using System;
using LitwareLib;


namespace EmployeeManagementSystem
{

    /// <remarks>
    /// Represents a Employee Management console application.
    /// </remarks>
    internal class EmployeeManagement
    {
        static void Main(string[] args)
        {
            // Creating instance of employee class 
            Employee employee = new Employee();

            Console.WriteLine("--------EMPLOYEE REGISTRATION--------");

            try
            {
                Console.Write("Enter Employee Number: ");
                employee.EmpNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                employee.EmpName = Console.ReadLine();
                try
                {
                    Console.Write("Enter Employee Salary: ");
                    employee.Salary = double.Parse(Console.ReadLine());

                    employee.CalculateSalary();
                    Console.WriteLine("Employee Gross Salary: " + employee.GrossSalary);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Employee salary.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Employee Id.");
            }

        }
    }
}