using Exception_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25__Exceptions
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transite(delivery);
                Deliver(delivery);
            }
            catch (AccidentException ex)
            {
                Console.WriteLine($"There was an accident at {ex.Location} preventing us from delivering your parcel: {ex.Message}");
                delivery.DeliveryStaus = DeliveryStaus.UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deliver Fails due to: {ex.Message}");
                delivery.DeliveryStaus = DeliveryStaus.UNKNOWN;
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if(random.Next(1,10) == 1)
            {
                throw new InvalidOperationException("unable to process the item");
            }
            delivery.DeliveryStaus = DeliveryStaus.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 10) == 1)
            {
                throw new InvalidOperationException("parcel is damaged during the loading process ");
            }
            delivery.DeliveryStaus = DeliveryStaus.SHIPPED;
        }
        private void Transite(Delivery delivery)
        {
            FakeIt("On Its Way");
            if (random.Next(1, 5) == 1)
            {
                throw new AccidentException("356 some another street", "ACCIDENT !!");
            }
            delivery.DeliveryStaus = DeliveryStaus.INTRANSIT;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidAccidentException($"'{delivery.Adderss}' is invalid !!");
            }
            delivery.DeliveryStaus = DeliveryStaus.DELIVERED;
        }

        private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("."); 

        }
    }
}
