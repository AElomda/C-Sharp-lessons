using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25__Exceptions
{
    public class InvalidAccidentException : Exception
    {
        public string Location { get; set; }
        public InvalidAccidentException(string message) : base(message)
        {

        }
    }
}
