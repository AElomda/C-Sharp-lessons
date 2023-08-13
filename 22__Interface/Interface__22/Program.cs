using System;
namespace Interface
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region First Implicit
            //vehicle v1 = new Honda("Honda", "Civic", 2021);
            //Honda v2 = new Honda("Honda", "Accord", 2021);
            //ILoader v3 = new Caterpillar("Caterpillar", "CAT", 2020);
            //v3.Load(); 

            #endregion
            #region Second Explicit
            //IMove m = new Vehicle();
            //m.Move();
            //m.Turn(); 
            #endregion
            cashier c1 = new cashier(new Cash());
            c1.Checkout(99999.99m);



            Console.ReadKey();
        }
    }
    #region First Implicit
    //abstract class vehicle
    //{
    //    protected string Brand;
    //    protected string Model;
    //    protected int Year;

    //    public vehicle(string brand, string model, int year)
    //    {
    //        Brand = brand;
    //        Model = model;
    //        Year = year;
    //    }
    //}

    //interface IDrivable
    //{
    //    void Moev();
    //    void Stop();
    //}

    //interface ILoader
    //{
    //    void Load();
    //    void UnLoad();

    //}
    //class Honda : vehicle, IDrivable 
    //{
    //    public Honda(string brand, string model, int year): base(brand,model,year)
    //    {

    //    }

    //    public void Moev()
    //    {
    //        Console.WriteLine("Moving");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("Stopping");
    //    }
    //}

    //class Caterpillar : vehicle, ILoader, IDrivable
    //{
    //    public Caterpillar(string brand, string model, int year) : base(brand, model, year)
    //    {

    //    }
    //    public void Load()
    //    {
    //        Console.WriteLine("Loadind");
    //    }

    //    public void UnLoad()
    //    {
    //        Console.WriteLine("UnLoadind");

    //    }
    //    public void Moev()
    //    {
    //        Console.WriteLine("Moving");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("Stopping");
    //    }
    //} 
    #endregion
    #region Second Explicit
    //class Vehicle : IMove, IDisplace
    //{
    //    void IMove.Move()
    //    {
    //        Console.WriteLine("IMove move");
    //    }

    //    void IDisplace.Move()
    //    {
    //        Console.WriteLine("IDisplace move");

    //    }
    //}
    //interface IMove
    //{
    //    void Turn()
    //    {
    //        Console.WriteLine("Turning");
    //    }
    //    void Move();
    //}
    //interface IDisplace
    //{
    //    void Move();
    //} 
    #endregion 
    class cashier
    {
        private IPayment _Payment;
        public cashier(Cash payment)
        {
            _Payment = payment;
        }
        public void Checkout(decimal amount)
        {
            _Payment.Pay(amount);
        }
    }
    interface IPayment
    {
        void Pay(decimal amount);
    }
    class Cash : IPayment
    {
        public void Pay (decimal amount)
        {
            Console.WriteLine($"Cash Amount: ${Math.Round(amount,2):N0}");
        }
    }
    class Debit : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit Amount: ${Math.Round(amount, 2):N0}");
        }
    }
    class Visa : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Visa Amount: ${Math.Round(amount, 2):N0}");
        }
    }
    class Mastercard : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Mastercard Amount: ${Math.Round(amount, 2):N0}");
        }
    }
}