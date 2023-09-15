namespace SalarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employees
            Employee oliver = new Employee(1, "Oliver", 3000);
            Employee kymia = new Employee(2, "Kymia", 5000);
            Employee magnus = new Employee(3, "Magnus", 6000);

            Employee fatima = new Employee(4, "Fatima", 5000);
            Employee mats = new Employee(5, "Mats", 4000);
            Employee viktor = new Employee(6, "Viktor", 5000);
            Employee ara = new Employee(7, "Ara", 4000);
            Employee arwin = new Employee(8, "Arwin", 5000);

            //Outlets
            Outlet frolunda = new Outlet("Frölunda", 10);
            frolunda.AddEmployee(oliver);
            frolunda.AddEmployee(kymia);
            frolunda.AddEmployee(magnus);
            Console.WriteLine(frolunda.GetTotalOutletSalary());
            Outlet nordstan = new Outlet("Nordstan", 5);
            nordstan.AddEmployee(mats);
            nordstan.AddEmployee(viktor);
            nordstan.AddEmployee(ara);
            nordstan.AddEmployee(arwin);
            nordstan.AddEmployee(fatima);

            //Headquarters
            Headquarters HeadquarterSweden = new Headquarters(10);
            HeadquarterSweden.AddOutlet(frolunda);
            HeadquarterSweden.AddOutlet(nordstan);

            Console.WriteLine(HeadquarterSweden.GetTotalCompanySalary());


            //Creat a salary system for a company such as mcdonalds
            //There should be diffrent classes that do diffrent things
            //One class for employee Check
            //One class for outlets 
            //One class for headquarters
            //One class for salaries, Optional



        }
    }
}