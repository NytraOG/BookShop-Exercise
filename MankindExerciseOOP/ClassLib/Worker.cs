using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Worker : Human
    {
        private decimal _weeklySalary;
        private double _workHoursPerDay;

        public decimal WeeklySalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
