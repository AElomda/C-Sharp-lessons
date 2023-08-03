namespace Inheritance
{
    public class Employee
    {
        public const int MinimunLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }

        protected string Name { get; set; }

        protected decimal LoggedHours { get; set; }

        protected decimal Wage { get; set; }

        protected virtual decimal Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }
        private decimal CalculateBaseSalary()
        {
            return LoggedHours * Wage;
        }
        private decimal CalculateOverTime()
        {
            var additionalHours = ((LoggedHours - MinimunLoggedHours) > 0 ? LoggedHours - MinimunLoggedHours : 0);
            return additionalHours * Wage * OverTimeRate;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inheritance.", "");
            return $"{type}"+
                   $"\nId: {Id}" +
                   $"\nName:{Name}" +
                   $"\nLoggedHours:{LoggedHours}hrs" +
                   $"\nWage:{Wage}$/hr" +
                   $"\nBaseSalary: {Math.Round(CalculateBaseSalary(),2):N0}" +
                   $"\nOverTime: {Math.Round(CalculateOverTime(), 2):N0}";
        }

    }
}