using _28__Extention__Methods;
using System;
namespace Extention_method
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Extention Method
            //DateTime dt = DateTime.Now;
            //Console.WriteLine($"DateTime.Now: {dt}");
            //Console.WriteLine($"IsWeekEnd: {dt.IsWeekEnd()}");
            //Console.WriteLine($"IsWeekDay: {dt.IsWeekDay()}");
            ////Console.WriteLine($"IsWeekEnd: {DateTimeExtentions.IsWeekEnd(dt)}");
            ////Console.WriteLine($"IsWeekDay: {DateTimeExtentions.IsWeekDay(dt)}");
            //Console.WriteLine($"Is Leap year: {DateTime.IsLeapYear(2020)}"); 
            #endregion
            #region DateTimeOffset 

            //dt = new DateTime(2021, 3, 1, 11, 30, 00);
            //Console.WriteLine($"DateTime: {dt}");

            //DateTimeOffset dts = DateTimeOffset.Now;
            //Console.WriteLine($"DateTimeOffset: {dts}");

            //dts = DateTimeOffset.UtcNow;
            //Console.WriteLine($"DateTimeOffset.UtsNow: {dts}"); 
            #endregion
            #region TimeSpan
            //TimeSpan ts = new TimeSpan(2, 15, 0);
            //dt = dt.Add(ts);
            //Console.WriteLine($"DateTime.Now: {dt}");
            //dt = dt.AddDays(4);
            //Console.WriteLine($"DateTime + 4 Days: {dt}"); 
            #endregion

            Pizza p = new Pizza();
            //p = PizzaExtentions.AddDough(PizzaExtentions.AddSauce(PizzaExtentions.AddCheeze(PizzaExtentions.AddToppings(p, "black olives", 3.5m), true)), "Thin");

            p.AddDough("thin")
                .AddSauce()
                .AddCheeze(true)
                .AddToppings("black olives", 3.5m);

            Console.WriteLine(p);


            Console.ReadKey();
        }
    }
    static class PizzaExtentions
    {
        public static Pizza AddDough(this Pizza value, string type)
        {
            value.Content += $"\n{type} Dough X $4.00";
            value.TotalPrice += 4m;
            return value;
        }
        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"\nTomato Sauce X $2.00";
            value.TotalPrice += 2m;
            return value;
        }
        public static Pizza AddCheeze(this Pizza value, bool extra)
        {
            value.Content += $"\n{(extra? "extra": "regular")} Cheeze X ${(extra ? "6.00" : "4.00")}";
            value.TotalPrice += extra ? 6m : 4m;
            return value;
        }
        public static Pizza AddToppings(this Pizza value, string type, decimal price)
        {
            value.Content += $"\n{type} X ${price.ToString("#.##")}";
            value.TotalPrice += price;
            return value;
        }
    }
    class Pizza
    {

        public string Content { get; set; }
        public decimal TotalPrice { get; set; }
        public Pizza AddSauce()
        {
            this.Content += $"\nTOMATO Sauce X $2.00";
            this.TotalPrice += 2m;
            return this;
        }
        public override string ToString()
        {
            return $"{Content}\n-----------------------------\nTotalPrice: ${TotalPrice}";
        }
    }
}
