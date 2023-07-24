using System;
namespace consoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            // Date d1 = new Date(01,01,0001);
            // Date d1 = new Date(12, 2000);


            // Console.WriteLine(d1.GetDate());

            /* Employee e1 = new Employee();
             e1.Id = 1000;
             e1.FName = "Ahmed";
             e1.LName = "M.";

             Employee e2 = new Employee
             {
                 Id = 1000,
                 FName = "Ahmed",
                 LName = "M."
             };

             Employee e3 = new Employee (1000)
             {
                 FName = "Ahmed",
                 LName = "M."
             };

             Console.WriteLine(e3.DisplayName());*/

            Employee e1 = Employee.Create(1000, "Issam", "A.");

            Console.WriteLine(e1.DisplayName());

            Console.ReadKey();
        }

       

    }
    

    public class Date
    {
        private static readonly int[] DaysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;


        public Date(int day, int month, int year)  // Constructor
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeap ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }

            }

        }
        public Date(int year) : this(01, 01, year)
        {

        }
        public Date(int month, int year) : this(01, month, year)
        {

        }
        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
        }

    }
    public class Employee
    {
        private Employee() { }
        private Employee(int id, string fname, string lname)
        {
            this.id = id;
            this.fName = fname;
            this.lName = lname;

        }

        public static Employee Create(int id, string fname, string lname)
        {
            return new Employee(id, fname, lname);
        }

        private int id;
        private string fName;
        private string lName;

        public string DisplayName()
        {
            return $"Id: {id} Name:{fName} {lName}\n";
        }

    }
}