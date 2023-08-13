using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics Method
            //Print(1);
            //Print("Issam");
            //Print('F'); 
            #endregion

            #region Generics Class
            //var numbers = new Any<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.DisplyaList();
            //numbers.RemoveAt(1);
            //numbers.DisplyaList();

            //Console.WriteLine($"Length: {numbers.Count} items");
            //Console.WriteLine($"Empty: {numbers.IsEmpty} ");

            //Console.WriteLine("\n--------------------------------\n");

            //var people = new Any<Person>();
            //people.Add(new Person { Fname = "Ali", Lname = "N" });
            //people.Add(new Person { Fname = "Reem", Lname = "S" });
            //people.DisplyaList();
            //Console.WriteLine($"Length: {people.Count} items");
            //Console.WriteLine($"Empty: {people.IsEmpty} "); 
            #endregion

            #region Generic and Collection
            //Type safe (Generic)
            var people = new List<Person>();

            people.Add(new Person("Ali", "N"));
            people.Add(new Person("Reem", "S"));

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Length: {people.Count} items");
            Console.WriteLine($"Empty: {people.Count == 0} ");

            Console.WriteLine("------------------------");

            //not safe (Collection)
            var arr = new ArrayList();
            arr.Add(1);
            arr.Add("Good Morning");
            arr.Add(new Person("Ali", "N"));
            arr.Add(new { Fname = "Reem", Lname = "S" });

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Length: {arr.Count} items");
            Console.WriteLine($"Empty: {arr.Count == 0} "); 
            #endregion


            Console.ReadKey();
        }

        #region Generics Method
        //static void Print<T> (T value)
        //{
        //    Console.WriteLine($"DataType: {typeof(T)}");
        //    Console.WriteLine($"DataType:{value}");
        //}  
        #endregion
    }
    #region Generics Class
    //public class Person
    //{
    //    public string Fname { get; set; }
    //    public string Lname { get; set; }
    //    public override string ToString()
    //    {
    //        return $"'{Fname} {Lname}'";
    //    }

    //}
    //class Any<T> 
    //{
    //    private T[] _items;
    //    public void Add(T item)
    //    {
    //        if (_items is null)
    //        {
    //            _items = new T[] { item };
    //        }
    //        else
    //        {
    //            var length = _items.Length;
    //            var dest = new T[length + 1];
    //            for (int i = 0; i < length; i++)
    //            {
    //                dest[i] = _items[i]; 
    //            }
    //            dest[dest.Length - 1] = item;
    //            _items = dest;
    //        }
    //    }
    //    public void RemoveAt(int position)
    //    {
    //        if (position < 0 || position > _items.Length - 1)
    //            return;
    //        var index = 0;
    //        var dest = new T[_items.Length - 1];
    //        for (int i = 0; i < _items.Length; i++)
    //        {
    //            if (position == i)
    //                continue;
    //            dest[index++] = _items[i];
    //        }
    //        _items = dest;
    //    }
    //    public bool IsEmpty => _items is null || _items.Length == 0;
    //    public int Count => _items is null ? 0 : _items.Length;
    //    public void DisplyaList()
    //    {
    //        Console.Write("[");
    //        for (int i = 0; i < _items.Length; i++)
    //        {
    //            Console.Write(_items[i]);
    //            if(i < _items.Length - 1)
    //            {
    //                Console.Write(", ");
    //            }
    //        }
    //        Console.WriteLine("]");
    //    }
    //} 
    #endregion

    #region Generic and Collection
    public class Person
    {
        private string fname;
        private string lname;

        public Person(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }
        public override string ToString()
        {
            return $"'{fname} {lname}'";
        }
    } 
    #endregion
}
