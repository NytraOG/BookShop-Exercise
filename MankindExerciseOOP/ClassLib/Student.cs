using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Student : Human
    {
        private int _facultyNr;

        public int FacultyNr { get; set; }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
