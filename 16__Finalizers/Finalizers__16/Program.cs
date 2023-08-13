using System;
namespace Finalizers
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeSomeGarabege();
            Console.WriteLine($"Memory Used Before Collection {GC.GetTotalMemory(false):N}");
            GC.Collect();
            Console.WriteLine($"Memory Used After Collection: {GC.GetTotalMemory(true):N}");
            Console.ReadKey();
        }

        static void MakeSomeGarabege()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }
}
