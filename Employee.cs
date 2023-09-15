using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    internal class Employee
    {
        private int EmployeeId;
        private string Name;
        private double MonthlySalary;

        public Employee(int employeeId, string name, double monthlySalary) 
        { 
            EmployeeId = employeeId;
            Name = name;
            SetSalary(monthlySalary);
        }

        public void SetSalary(double monthlySalary)
        {
            if(monthlySalary >= 0)
            {
                MonthlySalary = monthlySalary;
            }else
            {
                Console.WriteLine("Invalid salary, please try again.");
            }
        }
        public int GetEmployeeID()
        {
            return EmployeeId;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetMonthlySalary()
        {
            return MonthlySalary;
        }

    }
}
