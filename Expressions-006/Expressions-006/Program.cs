using System;

namespace consoleApp1
{
    class progrsm
    {
        static void Main(string[] args)
        {
            // Primary Expression (return value)
            /* var amount = Math.Cos(30) + 1;
            Console.WriteLine(amount);

            //Void Expression
            Console.WriteLine("Turbo");

            //Assignment Precedence
            var x = 2;
            x = x + 10;
            Console.WriteLine(x);

            var z = 3;
            var y = 10;

            // Binary Operators

            Console.WriteLine($" z + y = {z + y}"); 
            Console.WriteLine($" z - y = {z - y}");
            Console.WriteLine($" z / y = {z / y}");
            Console.WriteLine($" z * y = {z * y}");
            Console.WriteLine($" z % y = {z % y}");

            var s = 8 / 4 / 2; //1  (left to reight)
            var m = 8 / (4 / 2); //4  
            Console.WriteLine(s);
            Console.WriteLine(m);

            var s1 = "";
            var s2 = "";
            var s3 = s1 = s2 = "TURBO"; // Assignment Precedence (right to left)*/

            // Null Coalescing
            /* string s1 = null;

            s1 = s1 ?? "TURBO";
            s1 = s1 ?? "Someone else";
            Console.WriteLine(s1);*/

            // Conditional Null
            string s1 = null; // null  not equal empty""

            //var s2 = s1.ToUpper(); //Null Reference Exception( BOOOOOOOOOOOOOOOOM )
            var s2 = s1?.ToUpper(); //Null Conditional Operator
            var s3 = s1 is null ? null : s1.ToUpper();
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            // Statement vs Statement blocks
            Console.WriteLine("Hi"); //Statement
            {
                Console.WriteLine("Hello");   // Statement blocks
                Console.WriteLine("Welcome");
            }

            // Expression Statement
            //1. Change state
            var name = "turbo";
            name = name + "A.";

            //2. Call something that change the state 
            name = name.ToUpper();
            Console.WriteLine(name);

            //3. Assignment
            name = name + "A.";

            //4. Increment / decrement
            var totalFriends = 150;

            ++totalFriends;
            Console.WriteLine(totalFriends);

            --totalFriends;
            Console.WriteLine(totalFriends);

            var x = 2;
            Console.WriteLine(x++); //2
            Console.WriteLine(x); //3

            // Object Instansiation

            object o = new object();

//  -----------------------------------------------------------------------------//
            // Selection Statement (if,if else, switch)
            // if
            var mark = 90;
            if(mark >= 85)
                Console.WriteLine("Excellent");

            // if else
            var degree = 55;
            if (degree >= 60)
            {
                Console.WriteLine("Passed");
            }
            else if (mark >= 55)
            {
                Console.WriteLine("you have a chance in a make up exam");
            }
            else
            {
                Console.WriteLine("Failed"); 
            }

            // switch
            var amountEGP = 100;
            var currType = "USD";
            var output = 0d;

            // EGY = 1.41 USD, EUR = 1.19 , CAD = 1.78
            var EGPTOUSD = 1.41d;
            var EGPTOEUR = 1.19d;
            var EGPTOCAD = 1.78d;

            switch (currType )
            {
                case "USD":
                    output = amountEGP * EGPTOUSD;
                    Console.WriteLine($"{amountEGP} EGP = {output} USD");
                    break;
                case "EUR":
                    output = amountEGP * EGPTOEUR;
                    Console.WriteLine($"{amountEGP} EGP = {output} EUR");

                    break;
                case "CAD":
                    output = amountEGP * EGPTOCAD;
                    Console.WriteLine($"{amountEGP} EGP = {output} CAD");

                    break;
                default:
                    Console.WriteLine("unknown currency type");
                    break;
            }

            var num = 3;
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("odd");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("even");
                    break;
            }

            object n = 3;
            switch (n)
            {
                case int i:
                    Console.WriteLine($"It is int, sqr of {i} = {i*i}");
                    break;
                case string i:
                    Console.WriteLine($"It is string, Capitalization of {i} = {i.ToUpper()}");
                    break;
            }

            bool isVip = true;
             switch (isVip)
            {
                case bool i when i == true:
                    Console.WriteLine("Yes");
                    break;
                case bool i:
                    Console.WriteLine("No");
                    break;
            }
            var cardNo = 13;

            string cardName = cardNo switch
            {
                1 => "ACE",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                _ => cardNo.ToString()
            };
            Console.WriteLine(cardName);
//  -----------------------------------------------------------------------------//

            // Iterations 

            var counter = 0;
            while (counter < 10)
            {
                Console.Write(counter + " ");
                ++counter; 
            }

            Console.WriteLine();
            counter = 0;
            do
            {
                Console.Write(counter + " ");
                ++counter;
            } while (counter < 10);

            Console.WriteLine(  );

            for (var count = 0; count < 10; count++ )
            {
                Console.Write(count + " ");
            }

            Console.WriteLine( );

            // Fibonacci [0 ,1 ,1 ,2 ,3 ,5 ,8 ,13 ,21 ,34]

            for (int count = 0, prv= 0 , current = 1; count < 10; count++)
            {
                Console.Write( prv +" ");
                int newFIb = prv + current;
                prv = current;
                current = newFIb;
            }

            Console.WriteLine( );
             
            foreach (char c in "Full Stack Developer Cource")
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            var arr = new int[] { 1, 2, 4 };
            foreach (var m in arr)
            {
                Console.Write( m  + " ");
            }

            Console.WriteLine( );

            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //  -----------------------------------------------------------------------------//

            // Jump statment [ breal , continue , goto , return]

            var z = 0;
            while (z<10)
            {
                if (z > 5)
                    break; 
                Console.WriteLine(z);
                ++z;
            }

            Console.WriteLine( );

            for (int i = 0; i < 10 ; i++)
            { 
                if (i % 2 != 0)
                    continue;
                Console.Write(i + " ");
            }

            Console.WriteLine();

            var b = 0;
            start:
            if(b<=5)
            {
                Console.Write(b + " ");
                ++b;
                goto start;
            }

            var input = .44;
            var  result = AsPercentage(input);
            Console.WriteLine(result);






            Console.ReadKey();
        }

        static double AsPercentage(double  amount)
        {
            return amount * 100;
        }
    }
}