using System;

namespace consoleApp1
{
    class progrsm
    {
         static void Main(string[] args)
        {
            //this is a single line comment 
            /*this
             * is
             * a multi
             * line 
             * comment
             */

            int num;
            num = 5;        //Delegation
                            //value data type
                            //stored in stack
            int num2 = 5;   //Initialization
                            
                            
            string s1;
            s1 = "Ahmed";

            string s2 = "A."; // refrence data type
                             //identifier stored in stack , content stored in heap

            string s3 = s1 + " " + s2;  //regular concatenation (plus sign)
            Console.WriteLine( s3 );

            string s4 = $"{s1} {s2}";   //string interpolation
            Console.WriteLine(s3);

            Console.WriteLine( $"int: [{int.MinValue} {int.MaxValue}]");

            //var
            var s5 = "Turbo";
            var f = 0f;
            var d = 0d;
            var m = 0m;
            var u = 0u;
            var l = 0l;
            var ul = 0ul;

            int onemillion = 1_000_000; //using _

            var result = 200 / 3.0; //.0 convert int to double

            //dymanic
            dynamic x = 9;
            x = "ABC";
            x = 10m;

            char letter = 'A'; //cahr stores in the stack


        }
    }
}
   
