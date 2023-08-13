namespace Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;

        protected bool TaskCompleted { get; set; }

        public Developer(int id, string name, decimal loggedHours, decimal wage,
            bool TaskCompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = TaskCompleted;
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }
        private decimal CalculateBouns()
        {
            if(TaskCompleted)
            return base.Calculate() * Commission;
            return 0; 
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nTaskCompleted: ${(TaskCompleted ? "Yes": "N0")}" +
                   $"\nBouns: ${Math.Round(CalculateBouns(), 2):N0}" +
                   $"\nNetSalary: ${Math.Round(this.Calculate(), 2):N0}";
        }

    }


}