using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MankindExerciseOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var protoMensch = new Human("bob", "becher");
            var protoStudent = new Student("hans", "maier", 1);
            var protoWorker = new Worker("bernd", "busch", 200, 5);

            protoMensch.GetInfo();
            protoStudent.GetInfo();
            protoWorker.GetInfo();
        }
    }
}
