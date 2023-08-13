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

        public static double TAX = 0.03;

        // ‹AccessModifier> public, private, protected,
        // Fields -> ‹AccessModifier>  <DataType> <FieldsName> = <Initialvalue>

        public string fName;
        public string lName;
        public double wage;
        public double LoggedHours;


        private double Calculate() => wage * LoggedHours;
        private double CalculateTax() => Calculate() * TAX;
        private double CalculateNet() => Calculate() - CalculateTax();

        public string PtintSlip()
        {
            return $"\nFirstName: {fName}" +
                   $"\nLastNamr: {lName}"+
                   $"\nWage: {wage}"+
                   $"\nLoggedHours: {LoggedHours}" +
                   "--------------------------------"+
                   $"\nsalary: ${Calculate()}"+
                   $"\nDeductable Tax ({TAX * 100}%) Amount: ${CalculateTax()}"+
                   $"\nnetSalay: {CalculateNet()}\n";
             

         }


    }
}