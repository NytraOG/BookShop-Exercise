using System;

namespace ClassLib
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value.Substring(0, 1) == value.Substring(0, 1).ToLower() || value.Substring(1,value.Length-1) != value.Substring(1,value.Length-1).ToLower())
                {
                    string anfangsBuchstabe = value.Substring(0, 1).ToUpper();
                    string restString = value.Remove(0, 1).ToLower();

                    firstName = anfangsBuchstabe + restString;
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Substring(0, 1) == value.Substring(0, 1).ToLower() || value.Substring(1, value.Length - 1) != value.Substring(1, value.Length - 1).ToLower())
                {
                    string anfangsBuchstabe = value.Substring(0, 1).ToUpper();
                    string restString = value.Remove(0, 1).ToLower();

                    lastName = anfangsBuchstabe + restString;
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\n" +
                              $"First Name: \t {firstName}\n" +
                              $"Last Name: \t {lastName}");
        }
    }
}
