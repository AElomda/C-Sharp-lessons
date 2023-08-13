using System;
namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(1.99m);
            dollar.SetAmount(1.99m);  //set
            Console.WriteLine(dollar.Amount);  //get 
            Console.WriteLine(dollar.IsZero);  




            Console.ReadKey();
        }
    }

    public class Dollar
    {

        private decimal _amount;  //1.99, 120.99, 5.00 [1.009 => 1.01]
        public int Amount { get; set; }
        //public decimal Amount
        //{
        //    get
        //    {
        //        return this._amount;
        //    }
        //    private set
        //    {
        //        this._amount = value;
        //    }
        //}

        public decimal getAmount()
        {
            return _amount;
        }
        public void setAmount(decimal value)
        {
            _amount = value;
        }
        public void SetAmount(decimal value)
        {
            Amount = value;
        }
        public bool IsZero => _amount == 0;

        public decimal ConversionFactor { get; set; } = 1.99m;   

        public Dollar(decimal amount)
        {
            this._amount = ProccessValue(amount);

        }
        private decimal ProccessValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);

    }
}
