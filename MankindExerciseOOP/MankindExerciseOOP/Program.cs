using ClassLib;
using System;

namespace MankindExerciseOOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input;

            do
            {
                input = Console.ReadLine();

                var stringManager = new StringManager();
                var datenListe = stringManager.SplitString(input);

                string firstName;
                string lastName;

                switch (datenListe.Count)
                {
                    case 3:
                        {
                            firstName = (string)datenListe[0];
                            lastName = (string)datenListe[1];
                            var facultyNr = Convert.ToInt32(datenListe[2]);

                            var student = new Student(firstName, lastName, facultyNr);

                            student.GetInfo();
                            break;
                        }
                    case 4:
                        {
                            firstName = (string)datenListe[0];
                            lastName = (string)datenListe[1];
                            var weeklySalary = (decimal)datenListe[2];
                            var workHoursPerDay = (int)datenListe[3];

                            var worker = new Worker(firstName, lastName, weeklySalary, workHoursPerDay);

                            worker.GetInfo();
                            break;
                        }

                    default:
                        break;
                }
            } while (!string.IsNullOrEmpty(input));
        }
    }
}
