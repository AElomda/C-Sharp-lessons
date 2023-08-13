using System;
namespace Generic_Delegate__24
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Covariance Generic
            IEnumerable<int> list1 = new int[] { 2, 5, 6, 7, 9, 1, 2, 3, 4, 8 };

           
            PrintNumber(list1, n => n < 6, () => Console.WriteLine("Numbers Less Than 6"));

            PrintNumber(list1, n => n < 7, () => Console.WriteLine("Numbers Less Than 7"));

            PrintNumber(list1, n => n % 2 == 0, () => Console.WriteLine("Even Numbers"));


            IEnumerable<decimal> list2 = new decimal[] { 2.5m, 5.3m, 6.33m, 7.1m, 9.44m, 1.75m, 3.4m, 3, 4.2m, 8.7m };
            PrintNumber(list1, n => n >= 6.33, () => Console.WriteLine("Number Greater than equal 6.33"));
            #endregion

            Console.WriteLine("\n------------------------------\n");


            Action<string> action = Print;
            action("Issam"); 

            Func<int, int, int> addD = Add;
            Console.WriteLine(addD(2,2));

            Predicate<int> predicate = IsEven;
            Console.WriteLine(predicate(3));


            Console.ReadKey();
        }
        #region Covariance Generic
        static void PrintNumber<T>(IEnumerable<T> numbers, Func<T, bool> filter, Action action )
        {
            action();
            foreach (var n in numbers)
            {
                if (filter(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
        #endregion


        static void Print(string name) => Console.WriteLine(name);
        static int Add(int n1, int n2) => n1 + n2;
        static bool IsEven(int n) => n % 2 == 0;

    }
}


