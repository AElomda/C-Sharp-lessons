using Delegates;
using System;

namespace Delegates_013
{
    public class Report
    {
        public delegate bool IllegibleSales(Employee e);
        public void ProccessEmployee(Employee[] employees,string title, IllegibleSales isIllegible)
        {
            Console.WriteLine("Title ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                if (isIllegible(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
