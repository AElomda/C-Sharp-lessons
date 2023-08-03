using System;
namespace Enums__20
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine((int)Month.FEB);

            //var day = (DAY.SATURDAY | DAY.SUNDAY);
            //if(day.HasFlag(DAY.WEEKEND))
            //{
            //    Console.WriteLine("Enjoy Your Weekend");
            //}

            //var day = "feb";
            //if (Enum.TryParse(day,out Month month))
            //{
            //    Console.WriteLine(month);

            //}
            //else
            //{
            //    Console.WriteLine("envalid entry");
            //}


            foreach (var month in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month),month)}");
            }


            Console.ReadKey();
        }
    }
    enum Month
    {
        // Simple Enum
        JAN = 1,
        FEB,
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        VOV,
        DEC
    }
    [Flags]
    enum DAY
    {
        // Flags Enum
        NONE       = 0b_0000_0000,  //0
        MONDAY     = 0b_0000_0001,  //1
        TUESDAY    = 0b_0000_0010,  //2
        WEDNESDAY  = 0b_0000_0100,  //4
        THURSDAY   = 0b_0000_1000,  //8
        FRIDAY     = 0b_0001_0000,  //16
        SATURDAY   = 0b_0010_0000,  //32
        SUNDAY     = 0b_0100_0000,  //64
        BUSDAY     = MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY,
        WEEKEND    = SATURDAY | SUNDAY // 0b_0110_0000
    }
}
