using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(1000, "Ali A.", 180, 10);

            Maintanence ms = new Maintanence(1001, "Salem M.", 182, 8);

            Sales s = new Sales(1002, "Sally N.", 176, 9, 0.05m, 10000m);

            Developer d = new Developer(1003, "Issam N.", 186, 15, true);

            Employee[] employees = { m, ms, s, d, };
            foreach (var employee in employees)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine(employee);
            }
            Console.ReadKey();
        }
    }
}