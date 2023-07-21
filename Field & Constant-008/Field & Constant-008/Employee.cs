using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // «ClassModifier› -› public, internal (default)
    //<ClassModifier> class <ClassName>
    // {
    //    class block
    // }

    public class Employee
    {
        // ‹AccessModifier> public, private, protected,
        // Constant -> ‹AccessModifier> const <DataType> <ConstantName> = <value>;

        public const double TAX = 0.03;

        // ‹AccessModifier> public, private, protected,
        // Fields -> ‹AccessModifier>  <DataType> <FieldsName> = <Initialvalue>

        public string fName;
        public string lName;
        public double wage;
        public double LoggedHours;


    }
}