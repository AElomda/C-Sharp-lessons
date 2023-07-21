using System;
namespace ConsoleApp1
{
    class program
    {
        static void Main (string[] args)
        {
            Employee[] emps = new Employee[2];
            /* Object (istance) Syntax
               Declaration <Type> <ObjectName>;
               Assignment <ObjectName> = new  <Type>();
               Initialization <Type> <ObjectName> <Type>(); */

            Employee e1 = new Employee();
            Console.Write("Enter Your First Name: ");
            e1.fName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            e1.lName = Console.ReadLine();

            Console.Write("Wage: ");
            e1.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;

            foreach (var emp in emps)
            {
                var netSalay = emp.wage * emp.LoggedHours - (emp.wage * emp.LoggedHours * Employee.TAX);
                Console.WriteLine($"FirstName: {emp.fName}");
                Console.WriteLine($"LastNamr: {emp.lName}");
                Console.WriteLine($"Wage: {emp.wage}");
                Console.WriteLine($"LoggedHours: {emp.LoggedHours}");
                Console.WriteLine($"netSalay: {netSalay}");
            }

            //var netSalay = e1.wage * e1.LoggedHours - (e1.wage * e1.LoggedHours * Employee.TAX);

           /* Console.WriteLine($"FirstName: {e1.fName}");
            Console.WriteLine($"LastNamr: {e1.lName}");
            Console.WriteLine($"Wage: {e1.wage}");
            Console.WriteLine($"LoggedHours: {e1.LoggedHours}");
            Console.WriteLine($"netSalay: {netSalay}"); 
           */




            Console.Read();
        }
    }
}