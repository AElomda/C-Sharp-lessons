using System;
using System.Reflection;

namespace ReflectionAndMetaData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Obtaining Types
            //Type t1 = DateTime.Now.GetType();  // at runtime
            //Console.WriteLine(t1);
            //Type t2 = typeof(DateTime); // at compile time 
            //Console.WriteLine(t2);
            //Console.WriteLine($"FullName: {t1.FullName}"); // NameSpace.TypeName
            //Console.WriteLine($"NameSpace: {t1.Namespace}"); //NameSpace
            //Console.WriteLine($"Name: {t1.Name}"); //NameSpace
            //Console.WriteLine($"BaseType: {t1.BaseType}"); //NameSpace

            //Console.WriteLine($"IsPublic): {t1.IsPublic}");
            //Console.WriteLine($"Assembly): {t1.Assembly}");

            //Type t3 = typeof(int[,]);
            //Console.WriteLine($"T3 Type: {t3.Name}");

            //var nestedTypes = typeof(Employee).GetNestedTypes();
            //for (int i = 0; i < nestedTypes.Length; i++)
            //{
            //    Console.WriteLine(nestedTypes[i]);
            //}

            //var t4 = typeof(int);
            //var interfaces = t4.GetInterfaces();
            //for (int i = 0; i < interfaces.Length; i++)
            //{
            //    Console.WriteLine(interfaces[i]);
            //} 
            #endregion

            #region Instantiating Types
            //Console.Write("Enemy: ");
            //do
            //{
            //    var input = "ReflectionAndMetaData." + Console.ReadLine();
            //    object obj = null;
            //    try
            //    {
            //        var aName = typeof(Program).Assembly.GetName().Name;
            //        var enemy = Activator.CreateInstance("ReflectionAndMetaData", input);
            //        obj = enemy.Unwrap(); 
            //    }
            //    catch
            //    {

            //    }
            //    switch (obj)
            //    {
            //        case Goon g:
            //            Console.WriteLine(g);
            //            break;
            //        case Agar a:
            //            Console.WriteLine(a);
            //            break;
            //        case Pixa p:
            //            Console.WriteLine(p);
            //            break;
            //        default:
            //            Console.WriteLine("Unknown Enemy");
            //            break;
            //    }
            //} while (true); 
            #endregion

            #region BankAccount
            //BankAccount account = new BankAccount("A123", "Issam A.", 1000);
            //account.OnNegativeBalance += Account_OnNegativeBalance;
            //account.Withdraw(500);
            //account.Withdraw(600);
            //Console.WriteLine(account); 
            #endregion

            #region Reflecting Members
            //Console.WriteLine("MemberInfo");
            //MemberInfo[] members = typeof(BankAccount).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (var member in members)
            //{
            //    Console.WriteLine(member);
            //}

            //Console.WriteLine("FieldInfo");
            //FieldInfo[] fields = typeof(BankAccount).GetFields( BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (var field in fields)
            //{
            //    Console.WriteLine(field);
            //}

            //Console.WriteLine("PropertyInfo");
            //PropertyInfo[] properties = typeof(BankAccount).GetProperties();
            //foreach (var proberty in properties)
            //{
            //    Console.WriteLine(proberty.GetGetMethod());
            //    Console.WriteLine(proberty);
            //}

            //Console.WriteLine("EventInfo");
            //EventInfo[] events = typeof(BankAccount).GetEvents();
            //foreach (var e in events)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine("ConstructorInfo");
            //ConstructorInfo[] ctors = typeof(BankAccount).GetConstructors();
            //foreach (var ctor in ctors)
            //{
            //    Console.WriteLine(ctor);
            //} 
            #endregion

            var account = new BankAccount("A123", "Issam A.", 0);
            Type t = typeof(BankAccount);

            Type[] parametersType = { typeof(decimal) };
            MethodInfo method = t.GetMethod("Deposit");
            method.Invoke(account, new object[] { 500 });
            Console.WriteLine(account);

            Console.ReadKey();
        }

        private static void Account_OnNegativeBalance(object? sender, EventArgs e)
        {
            var bankAccount = (BankAccount)sender;
            Console.WriteLine("Negative Balance!!!");
        }
    }
    #region Obtaining Types
    //class Employee
    //{

    //} 
    #endregion
    #region Instantiating Types
    //    public class Goon
    //    {
    //        public override string ToString()
    //        {
    //            return $"{{ Speed: {20}, HitPower: {13}, Strenght: {7} }}";
    //        }
    //    }
    //    public class Agar
    //    {
    //        public override string ToString()
    //        {
    //            return $"{{ Speed: {23}, HitPower: {11}, Strenght: {12} }}";
    //        }
    //    }
    //    public class Pixa
    //    {
    //        public override string ToString()
    //        {
    //            return $"{{ Speed: {25}, HitPower: {10}, Strenght: {9} }}";
    //        }
    //    }
    //} 
    #endregion
    public class BankAccount
    {
        private string accountNo;
        private string holder;
        public decimal balance;

        public string AccountNo => accountNo;
        public string Holder => holder;
        public decimal Balance => balance;

        public event EventHandler OnNegativeBalance; 

        public BankAccount(string accountNo, string holder, decimal balance)
        {
            this.accountNo = accountNo;
            this.holder = holder;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
            if (this.balance < 0)
                this.OnNegativeBalance.Invoke(this, null);
        }
        public override string ToString()
        {
            return $"{{ Account No: {accountNo}, Holder: {holder}, Balance: {balance}}}";
        }
    }
}