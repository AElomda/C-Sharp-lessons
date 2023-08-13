using System;
namespace indexers
{
    class program
    {
        static void Main(string[] args)
        {
            //var ip = new IP(119, 112, 24, 55);
            var ip = new IP("119.112.24.55");

            Console.WriteLine(ip.Address);


            var FirstSegment = ip[0];

            Console.WriteLine($"IP Address: {ip.Address}");
            Console.WriteLine($"First Segment: {FirstSegment}");

            Console.ReadKey();
        }
    }
    public class IP
    {
        private int[] segments = new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }

        public IP(string IPAddress)
        {
            var segs = IPAddress.Split("");
            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }

        }
        public IP(int segmant1, int segmant2, int segmant3, int segmant4)
        {
            segments[0] = segmant1;
            segments[1] = segmant2;
            segments[2] = segmant3;
            segments[3] = segmant4;
        }

        public string Address => string.Join(".", segments);
    }
}