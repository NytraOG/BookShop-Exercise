using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Worker : Human
    {
        private decimal weeklySalary;
        private double workHoursPerDay;
        private decimal salaryPerHour;

        public decimal WeeklySalary { get; set; }
        public double WorkHoursPerDay { get; set; }
        public decimal SalaryPerHour { get; set; }

        public Worker(string firstName, string lastName, decimal weeklySalary, double workHoursPerDay) : base(firstName, lastName)
        {
            WeeklySalary = weeklySalary;
            WorkHoursPerDay = workHoursPerDay;

            SalaryPerHour = weeklySalary / (decimal) (5 * workHoursPerDay);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Weekly Salary: \t {WeeklySalary:C}\n" +
                              $"Hours per Day: \t {WorkHoursPerDay}\n" +
                              $"Salary per Hour: {SalaryPerHour:C}");
        }
    }
}
