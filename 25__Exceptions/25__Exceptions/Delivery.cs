namespace Exception_
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Adderss { get; set; }
        public DeliveryStaus DeliveryStaus { get; set; }

        public override string ToString()
        {
            return $"{{\n   Id: {Id},\n   Customer: {CustomerName},\n   Adderss: {Adderss},\n   Status: {DeliveryStaus}\n}}";
        }
    }
}
