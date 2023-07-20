using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //Implicit Casting
            // Int32 (int) - Int64 (Long)

            int numberInt = 100;
            long numberLong = numberInt;


            //Explicit Casting
            long nl = 1000;
            //int nI = nl;  (Error)
            if(nl <= long.MaxValue)
            {
                int nI = (int)nl;
            }

            double d = 1234.8;
            //int i = d;  (Error)
            int i = (int)d;
            Console.WriteLine(i);


            //Boxing unBoxing  (Convert from DataType Value to DataType Ref.)
            int x =10;  //Value Type
            object obj; //Reference Type
            obj = x;    //Conversion done implicitly (Boxing value to ref.)
            int y = (int)obj; //Unboxing (from ref. to value)


            //Convert From String to a Numerical one
            string stringValue = "120";
            // int number = stringValue; (Error) 

            //1. type.Parse() => int.Parse(), double.Parse()......
            int number = int.Parse(stringValue);
            Console.WriteLine(number);

            string Value = "99999999999999";
            if(int.TryParse (Value , out int num))
            {
                Console.WriteLine(num);
            }else
            {
                Console.WriteLine("Invalid number provided ");
            }

            //Convert Class

            //Bit Convertor
            var number1 = 255;
            var bytes = BitConverter.GetBytes(number1);
            foreach (var b in bytes)
            {
                Console.WriteLine(b);
                var binary = Convert.ToString(b, 2).PadLeft (8, '0');
                Console.WriteLine(binary);
            }


            var name = "Issam";
            char[] letters = name.ToCharArray();

            foreach (var l in letters)
            {
                int ascii = Convert.ToInt32(1);
                var output = $"'{l}' ASCII: {ascii}, Binary: {Convert.ToString(ascii ,2).PadLeft(8,'0')}, Hexadecimal: {ascii:x} ";
                Console.WriteLine(output);
            }


            string[] hexValues = { "49", "73", "73", "61", "6D" };
            foreach (var hex in hexValues)
            {
                int value = Convert.ToInt32(hex, 16);
                var stringValue1 = char.ConvertFromUtf32(value); //1#convert int to string
                var ch = (char)value; //2#
                Console.WriteLine(ch);
                Console.WriteLine(stringValue1);
            }

            var hex1 = "8E2";
            int nummber0 = Int32.Parse(hex1, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(nummber0);



            Console.ReadKey();

        }
    }

}
