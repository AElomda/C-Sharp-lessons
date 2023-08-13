using System;
namespace Methods__009
{
    class program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            // Caller
            // d1.DoSomething();
            // var age = 18;
            //  d1.DoSomething2(ref age);
            // var z = 100 + d1.DoSomething1(); // Primary Exp. 

            //d1.DoSomething2(18); // 18 is the argument passed

            //int age;
            //d1.DoSomething3(out age);

            //Console.WriteLine(age);

            /* var numString = "123456";

             int number;
             if (!int.TryParse(numString,out number))
             {
                 Console.WriteLine("Invalid Number");
             }
             else
             {
                 Console.WriteLine($"you provided a valid number {number}");
             }*/


            //d1.Promote(100, "Amman-Egypt-Amman", "Kampenski 3days/2nights");

            var result = d1.IsEven(6);
            Console.WriteLine(result);

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            d1.printEvens(numbers);



            Console.ReadKey();
        }
    }

    public class Demo
    {
        // Methods syntax (simple)
        //<AccessModifer> <DataType>/Void  MethodeName (<Parameter List>)
        // {
        //     series of statment
        // }

       /* public void DoSomething()  //Calee
        {
            Console.WriteLine("Do Something...");
        }

        public int DoSomething1()
        {
            var x = 100;
            return x * x;
        }

        public void DoSomething2(ref int age)  //age is parameter
        {
            age = age + 3;
        }

        public void DoSomething3(out int age)  //age is parameter
        {
            age = 18;
            age = age + 3;
        }*/



        // Method Signiture (Name + parameter type + parameter order )
        
        public void DoSomething (int x , double y)
        {

        }
        public void DoSomething(double x, int y)
        {

        }

        // Method Overloading (A common way of implementing Polymerphism)

        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a promotion of ${amount}");

        }

        public void Promote(double amount, string trip)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip}");

        }

        public void Promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip} with {hotel}");

        }


        //Expression Body Method

        public bool IsEven(int number) => number % 2 == 0;


        // Local Method
        public void printEvens(int[] original)
        {
            foreach (var n in original)
            {
                if(iseven(n))
                {
                    Console.Write(n + " ");
                }

                bool iseven(int number)
                {
                    return number % 2 == 0;
                }

            }
        }

    }
}
