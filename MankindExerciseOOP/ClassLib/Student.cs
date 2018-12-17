using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Student : Human
    {
        private int facultyNr;

        public int FacultyNr { get; set; }

        public Student(string firstName, string lastName, int facultyNr) : base(firstName, lastName)
        {
            FacultyNr = facultyNr;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Faculty Nr.: \t {FacultyNr}");
        }
    }
}
