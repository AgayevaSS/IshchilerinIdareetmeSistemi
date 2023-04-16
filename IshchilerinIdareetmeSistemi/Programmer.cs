namespace IshchilerinIdareetmeSistemi
{
    internal partial class Program
    {
        class Programmer : IEmployee
        {
            private string _name;
            private double _hourlyRate;
            private int _hoursWorked;

            public Programmer(string name, double hourlyRate, int hoursWorked)
            {
                _name = name;
                _hourlyRate = hourlyRate;
                _hoursWorked = hoursWorked;
            }

            public double CalculateSalary()
            {
                return _hourlyRate * _hoursWorked;
            }

            public int CalculateVacationDays()
            {
                return 10;
            }

        }
    }
}
