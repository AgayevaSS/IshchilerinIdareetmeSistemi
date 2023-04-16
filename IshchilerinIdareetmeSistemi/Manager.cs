namespace IshchilerinIdareetmeSistemi
{
    internal partial class Program
    {
        class Manager : IEmployee
        {
            private string _name;
            private double _salary;

            public Manager(string name, double salary)
            {
                _name = name;
                _salary = salary;
            }

            public double CalculateSalary()
            {
                return _salary;
            }

            public int CalculateVacationDays()
            {
                return 15;
            }

        }
    }
}
