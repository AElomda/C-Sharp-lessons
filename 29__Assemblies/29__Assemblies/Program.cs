using DemoLib;
using System;
using System.IO;
using System.Reflection;

namespace Assemblies
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region How to access Assembly
            //var type = typeof(Employee);
            //Console.WriteLine(type);
            //var assembly = type.Assembly;
            //Console.WriteLine(assembly.FullName);
            //Demo.Trace(); 
            #endregion
            #region Accessing Metadata
            //var type = typeof(Program);
            //var assembly = type.Assembly;
            //Console.WriteLine($"Full Name: {assembly.FullName}");
            //Console.WriteLine($"Location: {assembly.Location}");
            //var assemblyName = assembly.GetName();
            //Console.WriteLine($"Name: {assemblyName.Name}");
            //Console.WriteLine($"Version: {assemblyName.Version}");
            //Console.WriteLine($"Total Key Token Length: {assemblyName.GetPublicKeyToken().Length}");
            //Console.WriteLine($"Code: {assemblyName.CodeBase}");
            //Console.WriteLine($"DateTime Assembly Name: {typeof(DateTime).Assembly.GetName().Name}"); 
            #endregion
            var type = typeof(Program);
            var assembly = type.Assembly;

           // var stream = assembly.GetManifestResourceStream("29__Assemblies.data.Countries.json");
            var stream = assembly.GetManifestResourceStream(type, "data.Countries.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write((char)data[i]);
                System.Threading.Thread.Sleep(300);
            }
            stream.Close();
            Console.ReadKey();
        }
    }
}
