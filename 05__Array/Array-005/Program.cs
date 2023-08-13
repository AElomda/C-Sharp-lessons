using System;

namespace consoleApp1
{
    class progrsm
    {
        static void Main(string[] args)
        {
            //Array is a reference type (variable stored in stack and value in Heap)
            //Single Dim. Array
            //1. Declaration
            /*string[] friends = new string[5];

            //2. Accessing Elements
            friends[0] = "Ali";
            friends[1] = "Reem";
            friends[2] = "Faisal";
            friends[3] = "Ahmed";
            friends[4] = "Abeer";

            friends.print();*/

            //-------------------------------------------------------------------

            //2.Initialization V1
            /*string[] frinds = new string[5] {
                "Ali",
                "Reem",
                "Faisal",
                "Ahmed",
                "Abeer"

            };
            frinds.print();*/

            //-------------------------------------------------------------------

            //2.Initialization V2
            /* string[] frinds ={
                 "Ali",
                 "Reem",
                 "Faisal",
                 "Ahmed",
                 "Abeer"

             };
             frinds.print();*/

            //-------------------------------------------------------------------

            //Multi Dim. Array (Rectangular Array)
            // such as cheez and suduku 

            //-------------------------------------------------------------------

            // Jagged Array (Array inside Array)
            /*var jagged = new int[][]
            {
                new int [] {1 , 2},
                new int [] {2 , 5 , 6},
                new int [] { 7 }

            };*/

            //-------------------------------------------------------------------

            //Indices and Ranges
            /*var friends = new string[] { "Ali", "Reem", "Faisel", "Ahmed", "Abeer" };
            var first = friends[0];
            Console.WriteLine(first);

            var slice1 = friends[..2]; //print fisrt two
            slice1.print();

            var slice2 = friends[2..]; //skip fisrt two
            slice2.print();

            var slice3 = friends[2..3]; //start from 2 ends at 3
            slice3.print();

            var slice4 = friends[2..^2]; //^ meaning skip from last 
            slice4.print();*/


            //-------------------------------------------------------------------

            //Bound checking
            var friends = new string[] { "Ali", "Reem", "Faisel", "Ahmed", "Abeer"};
            var item = friends[5];
            Console.WriteLine(item);


            Console.ReadKey();

        }



    }
    }


public static class Extentions
{
    public static void print <T>(this T[] source)
    {
        if (!source.Any())
        {
            Console.WriteLine("{}");
            return;

        }
        Console.Write("{");
        for(var i=0; i<source.Length; i++)
        {
            Console.Write($"{source[i]}");
            Console.Write(i < source.Length - 1 ? "," : "");
        }
        Console.WriteLine(" } ");
    }


}