using Delegates_013;
using System;
namespace Delegates
{
    class Program
    {
        public delegate void RectDelegate(decimal width, decimal height);
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee { Id = 1, Name = "Issam", Gender = "M", TotalSales = 65000m },
                new Employee { Id = 2, Name = "Reem", Gender = "M", TotalSales = 50000m },
                new Employee { Id = 3, Name = "Suzan", Gender = "M", TotalSales = 65000m },
                new Employee { Id = 4, Name = "Sara", Gender = "M", TotalSales = 40000m },
                new Employee { Id = 5, Name = "Salah", Gender = "M", TotalSales = 42000m },
                new Employee { Id = 6, Name = "Rateb", Gender = "M", TotalSales = 30000m },
                new Employee { Id = 7, Name = "Abeer", Gender = "M", TotalSales = 16000m },
                new Employee { Id = 8, Name = "Marwan", Gender = "M", TotalSales = 15000m }
        };

            var report = new Report();
            report.ProccessEmployee(emps, "Employee With Sales Greater Than $60,000", e => e.TotalSales > 60000m);
            report.ProccessEmployee(emps, "Employee With Sales Between $30,000 and $60,000", e =>  e.TotalSales >= 30000m && e.TotalSales < 60000m);
            report.ProccessEmployee(emps, "Employee With Sale Less Than < $30,000", e => e.TotalSales < 30000m);



            var helper = new RectangleHelper();

            RectDelegate rect;
            rect = helper.GetArea;
            rect += helper.GetPerimeter;

            rect(10, 10);

            rect -= helper.GetArea;
            Console.WriteLine("After unsubscribing rect.GetArea");
            rect(10, 10);

            Console.ReadKey();
        }
    }

    public class RectangleHelper
    {
        public void GetArea(decimal width, decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area: {width} * {height} = {result}");
        }
        public void GetPerimeter(decimal width, decimal height)
        {
            var result = 2 * (width + height);
            Console.WriteLine($"Perimeter: {2 * (width + height)} = {result}");
        }
    }
}
