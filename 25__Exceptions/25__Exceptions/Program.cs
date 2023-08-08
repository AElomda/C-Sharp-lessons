using _25__Exceptions;
using System;
using System.Reflection.Metadata;

namespace Exception_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exceptios
            //try
            //{
            //    var result = BadMethod();
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex) when (ex.Source == "25__Exceptions")
            //{
            //    Console.WriteLine("you can not divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("End");
            //} 
            #endregion

            var delivery = new Delivery { Id = 1, CustomerName = "Issam", Adderss = "123 st" };
            var service = new DeliveryService();
            service.Start(delivery);
            Console.WriteLine(delivery);
            Console.ReadKey();
        }
        #region Exceptios
        //static int BadMethod()
        //{
        //    var x = 2;
        //    var y = 0;
        //    return x / y;
        //} 
        #endregion
    }
}
