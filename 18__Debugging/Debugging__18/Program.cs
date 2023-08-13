using System;
namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = 1000;
            var members = 4;
 
            members = Reduce(members, 2);
            var share = Distribute(amount, members);
            Console.WriteLine(share);

            Console.ReadLine();
        }
        static int Reduce(int members, int value)
        {
            return members -= value;
        }
        static int Distribute(int amount, int members)
        {
            try
            {
                return amount / members;
            }
            catch (Exception ex)
            {
                // In Case Exception is Thrown
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                // CLeanups
            }
            return 0;
        }
    }
}
