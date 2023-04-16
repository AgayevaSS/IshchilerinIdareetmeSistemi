namespace IshchilerinIdareetmeSistemi
{
    internal partial class Program
    {
        class Designer : IEmployee
        {
            private string _name;
            private double _salary;
            private int _experienceYears;

            public Designer(string name, double salary, int experienceYears)
            {
                _name = name;
                _salary = salary;
                _experienceYears = experienceYears;
            }

            public double CalculateSalary()
            {
                return _salary + (_experienceYears * 500);
            }

            public int CalculateVacationDays()
            {
                return 12;
            }

        }

    }
}
