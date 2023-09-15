using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    internal class Headquarters
    {
        private Outlet[] Outlets;
        private int CurrentOutletCounts = 0;

        public Headquarters(int maxOutlets)
        {
            Outlets = new Outlet[maxOutlets];
        }

        public double GetTotalCompanySalary()
        {
            double total = 0;
            for(int i = 0; i < CurrentOutletCounts; i++)
            {
                total += Outlets[i].GetTotalOutletSalary();
            }
            return total;
        }
        public void AddOutlet(Outlet outlet)
        {
            if (CurrentOutletCounts < Outlets.Length)
            {
                Outlets[CurrentOutletCounts] = outlet;
                CurrentOutletCounts++;
            }else
            {
                Console.WriteLine("Headquarters maxmium numbers of outlets has been reached.");
            }
        }
    }
}
