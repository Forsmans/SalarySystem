using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    internal class Outlet
    {
        private string OutletLocation;
        private Employee[] Employees;
        private int CurrentEmployeeCount = 0;

        public Outlet(string outletLocation, int maxEmployee)
        {
            OutletLocation = outletLocation;
            Employees = new Employee[maxEmployee];
        }

        public double GetTotalOutletSalary()
        {
            double total = 0;
            for(int i = 0; i < CurrentEmployeeCount; i++)
            {
                total += Employees[i].GetMonthlySalary();
            }
            return total;
        }
        
        public void AddEmployee(Employee employee)
        {
            if (CurrentEmployeeCount < Employees.Length)
            {
                Employees[CurrentEmployeeCount] = employee;
                CurrentEmployeeCount++;
            }else
            {
                Console.WriteLine("Outlet has reached maximum emplyees.");
            }
        }
            
        public string GetOutletLocation()
        {
            return OutletLocation;
        }

    }
}
