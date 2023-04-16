using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IshchilerinIdareetmeSistemi
{
    internal partial class Program
    {
        private static object _name;

        static void Main(string[] args)
        {
            IEmployee[] employees = new IEmployee[3];
            employees[0] = new Manager("John Smith", 5000);
            employees[1] = new Programmer("Jane Doe", 50, 160);
            employees[2] = new Designer("Bob Williams", 6000, 5);

            foreach (IEmployee employee in employees)
            {
                Console.WriteLine($"Employee: {_name}");
                Console.WriteLine($"Salary: {employee.CalculateSalary()}");
                Console.WriteLine($"Vacation Days: {employee.CalculateVacationDays()}");
                Console.WriteLine();
            }
        }


        interface IEmployee
        {
            double CalculateSalary();
            int CalculateVacationDays();
        }
    }
}

