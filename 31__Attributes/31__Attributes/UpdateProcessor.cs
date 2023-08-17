partial class Program
{
    class UpdateProcessor
    {
        [Obsolete]
        public static void Download(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }
        public static void Install(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Installing {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }

        public static void DownloadAndInstall(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
                Console.WriteLine($"Installing {updates[i]}");
            }
        }
    }
}