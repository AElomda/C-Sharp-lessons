using System;
namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[2];
            /* Object (istance) Syntax
              Declaration <Type> <ObjectName>;
              Assignment <ObjectName> = new  <Type>();
              Initialization <Type> <ObjectName> <Type>(); */

            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Employee e1 = new Employee();

            Console.WriteLine("\nFirst Employee");
            Console.Write("Enter Your First Name: ");
            e1.fName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            e1.lName = Console.ReadLine();

            Console.Write("Wage: ");
            e1.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;

            Console.WriteLine("\nSecond Employee");
            Employee e2 = new Employee();

            Console.Write("Enter Your First Name: ");
            e2.fName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            e2.lName = Console.ReadLine();

            Console.Write("Wage: ");
            e2.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[1] = e2;

            foreach (var emp in emps)
            {
                /* var salary = emp.wage * emp.LoggedHours;
                 var taxAmount = salary * Employee.TAX;
                 var netSalay = salary - taxAmount;

                 Console.WriteLine($"\nFirstName: {emp.fName}");
                 Console.WriteLine($"LastNamr: {emp.lName}");
                 Console.WriteLine($"Wage: {emp.wage}");
                 Console.WriteLine($"LoggedHours: {emp.LoggedHours}");
                 Console.WriteLine("--------------------------------");
                 Console.WriteLine($"salary: ${salary}");
                 Console.WriteLine($"Deductable Tax ({Employee.TAX * 100}%) Amount: ${taxAmount}");
                 Console.WriteLine($"netSalay: {netSalay}\n"); */

                Console.WriteLine(emp.PtintSlip());
            }


            Console.Read();  
        }


    }
}