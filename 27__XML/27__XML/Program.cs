using System;
namespace XML
{
    class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Console.Write("First Name: ");
                var fname = Console.ReadLine();

                Console.Write("Last Name: ");
                var lname = Console.ReadLine();

                Console.Write("Hire Date: ");
                DateTime? hireDate = null;
                if(DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
                {
                    hireDate = hDate;
                }
                var empId = Generator.GenerateId(fname, lname, hireDate);
                var randomPassowrd = Generator.GenerateRandomPassword(8);
                Console.WriteLine($"{{\n Id: {empId},\n FName: {fname},\n Lname: {lname},\n hire Date: {hireDate},\nPassword: {randomPassowrd}\n");
            } while (1 == 1);
            

        }
    }
    /// <summary>
    /// The Main Generator Class
    /// </summary>
    /// <remarks>
    /// This class can generate employee Ids and passwords
    /// </remarks>
    public class Generator
    {
        /// <value> value of last Id sequence <value>   
        public static int LastIdSequence { get; private set; } = 1;

        /// <summary>
        /// Generate Employee Id by processing <paramref name="fname"/>,<paramref name="lname"/> and <paramref name="hireData"/>
        /// <list type="bullet">
        /// <item>
        /// <term>II</term>
        /// <description>Employee Initial (First letter of <paramref name="lname"/> and first letter of <paramref name="fname"/>)</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="hireData"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static string GenerateId(string fname, string lname, DateTime? hireData)
        {
            // II YY MM DD 01
            if (fname is null)
                throw new InvalidOperationException($"{nameof(fname)} can not be null");
            if (lname is null)
                throw new InvalidOperationException($"{nameof(lname)} can not be null");
            if (hireData is null)
            {
                hireData = DateTime.Now;
            }
            else
            {
                if(hireData.Value.Date < DateTime.Now.Date)
                    throw new InvalidOperationException($"{nameof(hireData)} can not be in the past ");
            }

            var yy = hireData.Value.ToString("yy");
            var mm = hireData.Value.ToString("MM");
            var dd = hireData.Value.ToString("dd");

            var code = $"{lname.ToUpper()[0]} {fname.ToUpper()[0]} {yy} {mm} {dd} {(LastIdSequence++).ToString().PadLeft(2, '0')}";
            return code;
        }

        public static string GenerateRandomPassword(int lenght)
        {
            const string ValidScope = "adcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = "";
            Random rnd = new Random();
            while(0 < lenght--)
            {
                result += (ValidScope[rnd.Next(ValidScope.Length)]);
            }
            return result;
        }
    }
}