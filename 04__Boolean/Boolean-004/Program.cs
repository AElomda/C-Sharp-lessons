using System;

namespace consoleApp1
{
    class progrsm
    {
        static void Main(string[] args)
        {
            /* bool isVar = true;

             var x = 10;
             var y = 10;
             Console.WriteLine(x == y); //x is equal to y?

             //Expretion 1 + 2 + 3
             var z = x == y;
             Console.WriteLine(z); */

            //-----------------------------------------------------------------

            /*var toatal = 1000;
            var vipThreshod = 900;

            var isVip = toatal >= vipThreshod;  //comparison operator

            Console.WriteLine(isVip);*/

            //-----------------------------------------------------------------

            /* var Vip = !true; //Negation
            Console.WriteLine(Vip); */

            //-----------------------------------------------------------------

            // conditional operators && ||

            //Logical AND &&
            /*Console.WriteLine(true && true ); //true
            Console.WriteLine(true && false); //false
            Console.WriteLine(false && true); //false
            Console.WriteLine(false && false);//false

            //Logical OR ||
            Console.WriteLine(true || true);  //true
            Console.WriteLine(true || false); //true
            Console.WriteLine(false|| true);  //true
            Console.WriteLine(false|| false); //false

            //Logical XOR ^
            Console.WriteLine(true ^true);  //false
            Console.WriteLine(true ^false); //true
            Console.WriteLine(false^ true);  //true
            Console.WriteLine(false^ false); //false */
            //-----------------------------------------------------------------

            //Short Circuit && ||

            /*Console.WriteLine(true & true); //true
            Console.WriteLine(true & false);//false
            Console.WriteLine(false& true);//false
            Console.WriteLine(false& false);//false*/

            //Short Circuit && ||
            // & |
            //bool value = true | Check();


            // == reference type

            var x = 1;
            var y = 1;

            //Compare the value (value type) (stored in stack)
            var z = x == y;
            Console.WriteLine(z); //true

            //compare the referenace (referenace type) (stored in Heap)
             var s1 = "Hello";
             var s2 = "Hello";
             var s3 = s1 == s2;
             Console.WriteLine(s3);  //true

            // Ternary Operator
            var total = 900;
            var vipThreshod = 100;
            var isVip = total >= vipThreshod ? true :false ;
            var discount = total >= vipThreshod ? 0.5m : 0.0m;



            Console.ReadKey();



        }
        static bool Check()
        {
            Console.WriteLine("checking....");
            return true;
        }
    }
}